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
    public class ChromeSession : IChromeSession
    {
        private readonly string _webSocketDebuggerUrl;
        private readonly string _id;
        private readonly ICommonCommandsExecutor _commandsExecutor;
        private readonly ConcurrentDictionary<string, ConcurrentBag<Func<object, Task>>> _handlers = new ConcurrentDictionary<string, ConcurrentBag<Func<object, Task>>>();
        private ICommandFactory _commandFactory;
        private IEventFactory _eventFactory;
        private SemaphoreSlim _initEvent = new SemaphoreSlim(1, 1);
        private ConcurrentDictionary<long, SemaphoreSlim> _requestWaitHandles = new ConcurrentDictionary<long, SemaphoreSlim>();
        private ICommandResponseFactory _responseFactory;
        private ConcurrentDictionary<long, ICommandResponse> _responses = new ConcurrentDictionary<long, ICommandResponse>();
        private WebSocket _webSocket;

        public ChromeSession(
            string webSocketDebuggerUrl,
            string id,
            ICommonCommandsExecutor commandsExecutor,
            ICommandFactory commandFactory,
            ICommandResponseFactory responseFactory,
            IEventFactory eventFactory
        )
        {
            // Sometimes binding to localhost might resolve wrong AddressFamily, force IPv4
            webSocketDebuggerUrl = webSocketDebuggerUrl.Replace("ws://localhost", "ws://127.0.0.1");

            _webSocketDebuggerUrl = webSocketDebuggerUrl;
            _id = id;
            _commandsExecutor = commandsExecutor;
            _commandFactory = commandFactory;
            _responseFactory = responseFactory;
            _eventFactory = eventFactory;
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

        public Task Close(CancellationToken cancellationToken)
        {
            return _commandsExecutor.ExecuteCloseTargetCommand(this, _id, cancellationToken);
        }

        public async Task WaitWhile(string expression, TimeSpan? timeout = null, CancellationToken cancellationToken = default)
        {
            var startTime = DateTime.Now;

            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                if (timeout.HasValue && DateTime.Now.Subtract(startTime) > timeout.Value)
                    throw new TimeoutException();

                var result = await _commandsExecutor.ExecuteEvaluateCommand(this, expression, cancellationToken)
                    .ConfigureAwait(false);

                result.ExceptionDetails?.Throw();

                var boolResult = result.Result is bool x ? x : result.Result != null;

                if (boolResult)
                    await Task.Delay(100, cancellationToken);
                else
                    return;
            }
        }

        public async Task<object> Execute(string expression, CancellationToken cancellationToken)
        {
            var result = await _commandsExecutor.ExecuteEvaluateCommand(this, expression, cancellationToken).ConfigureAwait(false);

            result.ExceptionDetails?.Throw();

            return result.Result;
        }

        public Task Naviagte(string url, CancellationToken cancellationToken)
        {
            return _commandsExecutor.ExecuteNavigateCommand(this, url, cancellationToken);
        }

        public Task<ICommandResponse> SendAsync<T>(CancellationToken cancellationToken)
        {
            var command = _commandFactory.Create<T>();
            return SendCommand(command, cancellationToken);
        }

        public Task<CommandResponse<T>> SendAsync<T>(IProtocolCommand<T> parameter, CancellationToken cancellationToken)
        {
            var command = _commandFactory.Create(parameter);
            var task = SendCommand(command, cancellationToken);
            return CastTaskResult<ICommandResponse, CommandResponse<T>>(task);
        }

        private Task<TDerived> CastTaskResult<TBase, TDerived>(Task<TBase> task) where TDerived: TBase
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

        public void Subscribe<T>(Func<T, Task> handler) where T : class
        {
            var handlerType = typeof(T);
            var handlerForBag = new Func<object, Task>(obj => handler((T)obj));
            _handlers.AddOrUpdate(handlerType.FullName,
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
            if (_handlers.TryGetValue(handlerKey, out handlers))
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
            var evntType = evnt.GetType();

            if (evntType.GetGenericTypeDefinition() == typeof(Event<>))
            {
                await handler(evntType.GetProperty("Params").GetValue(evnt));
            } else
            {
                await handler(evnt);
            }
        }

        private void HandleResponse(ICommandResponse response)
        {
            if (null == response) return;
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

        private async Task<ICommandResponse> SendCommand(Command command, CancellationToken cancellationToken)
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

            if (_webSocket.State != WebSocketState.Open)
                throw new InvalidOperationException("WebSocket closed");

            _webSocket.Send(requestString);

            ICommandResponse response = null;

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

        private bool TryGetCommandResponse(byte[] data, out ICommandResponse response)
        {
            response = _responseFactory.Create(data);
            return null != response;
        }

        private bool TryGetCommandResponse(string message, out ICommandResponse response)
        {
            response = _responseFactory.Create(message);
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
