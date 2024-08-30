using MasterDevs.ChromeDevTools.Protocol;
using MasterDevs.ChromeDevTools.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace MasterDevs.ChromeDevTools
{
    internal sealed class RemoteChromeSession : IChromeSession
    {
        private readonly string _webSocketDebuggerUrl;
        private readonly string _id;
        private readonly CommandFactory _commandFactory;
        private readonly CommandResponseFactory _commandResponseFactory;
        private readonly EventFactory _eventFactory;
        private readonly SemaphoreSlim _initEvent = new SemaphoreSlim(1, 1);
        private readonly ConcurrentDictionary<string, ConcurrentBag<Func<object, Task>>> _eventhandlers = new ConcurrentDictionary<string, ConcurrentBag<Func<object, Task>>>();
        private readonly ConcurrentDictionary<long, SemaphoreSlim> _requestWaitHandles = new ConcurrentDictionary<long, SemaphoreSlim>();
        private readonly ConcurrentDictionary<long, ICommandResponse> _responses = new ConcurrentDictionary<long, ICommandResponse>();
        private WebSocket? _webSocket;

        public RemoteChromeSession(
            string webSocketDebuggerUrl,
            string id,
            CommandFactory commandFactory,
            CommandResponseFactory responseFactory,
            EventFactory eventFactory
        )
        {
            // Sometimes binding to localhost might resolve wrong AddressFamily, force IPv4
            webSocketDebuggerUrl = webSocketDebuggerUrl.Replace("ws://localhost", "ws://127.0.0.1");

            _webSocketDebuggerUrl = webSocketDebuggerUrl;
            _id = id;
            _commandFactory = commandFactory;
            _commandResponseFactory = responseFactory;
            _eventFactory = eventFactory;
        }

        public Task<CommandResponse<T>> SendAsync<T>(ICommandParams<T> @params, string? sessionId, CancellationToken cancellationToken)
            where T : ICommandResult
        {
            var command = _commandFactory.Create(@params);

            command.SessionId = sessionId;

            var task = SendCommand(command, cancellationToken);

            return CastTaskResult<ICommandResponse, CommandResponse<T>>(task);
        }

        private async Task<ICommandResponse> SendCommand<T>(Command<T> command, CancellationToken cancellationToken)
            where T : ICommandResult
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new MessageContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
            };
            var requestString = JsonConvert.SerializeObject(command, settings);
            var requestResetEvent = new SemaphoreSlim(0, 1);

            _requestWaitHandles.AddOrUpdate(command.Id, requestResetEvent, (id, r) => requestResetEvent);

            await EnsureInit();

            if (_webSocket!.State != WebSocketState.Open)
                throw new InvalidOperationException("WebSocket closed");

            _webSocket.Send(requestString);

            ICommandResponse? response = null;

            try
            {
                await requestResetEvent.WaitAsync(cancellationToken);
            }
            finally
            {
                _responses.TryRemove(command.Id, out response);
                _requestWaitHandles.TryRemove(command.Id, out requestResetEvent);
            }

            return response;
        }

        private Task<TDerived> CastTaskResult<TBase, TDerived>(Task<TBase> task) where TDerived : TBase
        {
            var tcs = new TaskCompletionSource<TDerived>();

            task.ContinueWith(t => tcs.SetResult((TDerived)t.Result),
                TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith(t => tcs.SetException(t.Exception.InnerExceptions),
                TaskContinuationOptions.OnlyOnFaulted);
            task.ContinueWith(t => tcs.SetCanceled(),
                TaskContinuationOptions.OnlyOnCanceled);

            return tcs.Task;
        }

        private async Task EnsureInit()
        {
            if (null != _webSocket)
                return;

            await _initEvent.WaitAsync();

            try
            {
                if (null != _webSocket)
                    return;

                await Init();
            }
            finally
            {
                _initEvent.Release();
            }
        }

        private async Task Init()
        {
            _webSocket = new WebSocket(_webSocketDebuggerUrl);
            _webSocket.EnableAutoSendPing = false;
            _webSocket.MessageReceived += WebSocket_MessageReceived;
            _webSocket.Error += WebSocket_Error;
            _webSocket.Closed += WebSocket_Closed;
            _webSocket.DataReceived += WebSocket_DataReceived;

            await _webSocket.OpenAsync();
        }

        public void Dispose()
        {
            if (null == _webSocket) return;
            if (_webSocket.State == WebSocketState.Open)
            {
                _webSocket.Close();
            }
            _webSocket.Dispose();
        }

        public void Subscribe<T>(Func<Event<T>, Task> handler) where T : class
        {
            var handlerType = typeof(T);
            var handlerForBag = new Func<object, Task>(obj => handler((Event<T>)obj));
            _eventhandlers.AddOrUpdate(handlerType.FullName,
                (m) => new ConcurrentBag<Func<object, Task>>(new [] { handlerForBag }),
                (m, currentBag) =>
                {
                    currentBag.Add(handlerForBag);
                    return currentBag;
                });
        }

        private async Task HandleEvent(IEvent evnt)
        {
            if (null == evnt
                || null == evnt)
            {
                return;
            }
            var type = evnt.GetType().GetGenericArguments().FirstOrDefault();
            if (null == type)
            {
                return;
            }
            var handlerKey = type.FullName;
            ConcurrentBag<Func<object, Task>> handlers = null;
            if (_eventhandlers.TryGetValue(handlerKey, out handlers))
            {
                var localHandlers = handlers.ToArray();
                foreach (var handler in localHandlers)
                {
                    await ExecuteHandler(handler, evnt);
                }
            }
        }

        private async Task ExecuteHandler(Func<object, Task> handler, object evnt)
        {
            await handler(evnt);
        }

        private void HandleResponse(ICommandResponse response)
        {
            if (null == response)
                return;

            SemaphoreSlim requestMre;

            if (_requestWaitHandles.TryGetValue(response.Id, out requestMre))
            {
                _responses.AddOrUpdate(response.Id, id => response, (key, value) => response);
                requestMre.Release();
            }
            else
            {
                // in the case of an error, we don't always get the request Id back :(
                // if there is only one pending requests, we know what to do ... otherwise
                //if (1 == _requestWaitHandles.Count)
                //{
                //    var requestId = _requestWaitHandles.Keys.First();
                //    _requestWaitHandles.TryGetValue(requestId, out requestMre);
                //    _responses.AddOrUpdate(requestId, id => response, (key, value) => response);
                //    requestMre.Release();
                //}
            }
        }

        private bool TryGetCommandResponse(byte[] data, out ICommandResponse response)
        {
            response = _commandResponseFactory.Create(data);
            return null != response;
        }

        private bool TryGetCommandResponse(string message, out ICommandResponse response)
        {
            response = _commandResponseFactory.Create(message);
            return null != response;
        }

        private bool TryGetEvent(byte[] data, out IEvent evnt)
        {
            evnt = _eventFactory.Create(data);
            return null != evnt;
        }

        private bool TryGetEvent(string message, out IEvent evnt)
        {
            evnt = _eventFactory.Create(message);
            return null != evnt;
        }

        private void WebSocket_Closed(object sender, EventArgs e)
        {
        }

        private async void WebSocket_DataReceived(object sender, WebSocket4Net.DataReceivedEventArgs e)
        {
            ICommandResponse response;
            if (TryGetCommandResponse(e.Data, out response))
            {
                HandleResponse(response);
                return;
            }
            IEvent evnt;
            if (TryGetEvent(e.Data, out evnt))
            {
                await HandleEvent(evnt);
                return;
            }
            System.Diagnostics.Debug.Fail("Don't know what to do with response: " + e.Data);
        }

        private void WebSocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            throw e.Exception;
        }

        private async void WebSocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            ICommandResponse response;
            if (TryGetCommandResponse(e.Message, out response))
            {
                HandleResponse(response);
                return;
            }
            IEvent evnt;
            if (TryGetEvent(e.Message, out evnt))
            {
                await HandleEvent(evnt);
                return;
            }
            System.Diagnostics.Debug.Fail("Don't know what to do with response: " + e.Message);
        }
    }
}
