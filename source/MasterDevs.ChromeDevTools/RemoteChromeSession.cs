using MasterDevs.ChromeDevTools.Protocol;
using MasterDevs.ChromeDevTools.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
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
        private readonly ConcurrentDictionary<string, ConcurrentBag<Func<IEvent, Task>>> _eventHandlers =
            new ConcurrentDictionary<string, ConcurrentBag<Func<IEvent, Task>>>();
        private readonly ConcurrentDictionary<long, ResponseWaiter> _responseWaiters =
            new ConcurrentDictionary<long, ResponseWaiter>();
        private WebSocket? _webSocket;

        private sealed class ResponseWaiter
        {
            private readonly SemaphoreSlim _waiter = new SemaphoreSlim(0, 1);
            private ICommandResponse? _response = null;

            public async Task<ICommandResponse> Wait(CancellationToken cancellationToken)
            {
                await _waiter.WaitAsync(cancellationToken);

                return _response!;
            }

            public void Set(ICommandResponse response)
            {
                _response = response;

                _waiter.Release();
            }
        }

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

        public async Task<CommandResponse<T>> SendAsync<T>(ICommandParams<T> @params, string? sessionId, CancellationToken cancellationToken)
            where T : ICommandResult
        {
            var command = _commandFactory.Create(@params);

            command.SessionId = sessionId;

            var response = await SendInternal(command, cancellationToken);

            if (response is ErrorResponse errorResponse)
                throw new Exception(errorResponse.Error.Message + $" (Code: {errorResponse.Error.Code})");

            return (CommandResponse<T>)response;
        }

        private async Task<ICommandResponse> SendInternal<T>(Command<T> command, CancellationToken cancellationToken)
            where T : ICommandResult
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new MessageContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
            };
            var requestString = JsonConvert.SerializeObject(command, settings);
            var responseWaiter = new ResponseWaiter();

            _responseWaiters.AddOrUpdate(command.Id, responseWaiter, (key, value) => responseWaiter);

            await EnsureInit();

            _webSocket!.Send(requestString);

            try
            {
                return await responseWaiter.Wait(cancellationToken);
            }
            finally
            {
                _responseWaiters.TryRemove(command.Id, out _);
            }
        }

        public void Subscribe<T>(Func<Event<T>, Task> handler)
            where T : IEventParams
        {
            var name = typeof(T).GetEventName();
            var handlerForBag = new Func<IEvent, Task>(obj => handler((Event<T>)obj));

            _eventFactory.AddEventParamsType(name, typeof(T));

            _eventHandlers.AddOrUpdate(
                name,
                (m) => new ConcurrentBag<Func<IEvent, Task>>(new[] { handlerForBag }),
                (m, currentBag) =>
                {
                    currentBag.Add(handlerForBag);

                    return currentBag;
                }
            );
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

            if (_webSocket.State != WebSocketState.Open)
                throw new InvalidOperationException("WebSocket closed");
        }

        private async Task HandleEvent(IEvent @event)
        {
            if (!_eventHandlers.TryGetValue(@event.Method, out var handlers))
                return;

            foreach (var handler in handlers)
                await handler(@event);
        }

        private void HandleResponse(ICommandResponse response)
        {
            if (!_responseWaiters.TryGetValue(response.Id, out var responseWaiter))
                return;

            responseWaiter.Set(response);
        }

        private void WebSocket_Closed(object sender, EventArgs e)
        {
        }

        private async void WebSocket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            var response = _commandResponseFactory.Create(e.Data);

            if (response != null)
            {
                HandleResponse(response);
                return;
            }

            var @event = _eventFactory.Create(e.Data);

            if (@event != null)
            {
                await HandleEvent(@event);
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
            var response = _commandResponseFactory.Create(e.Message);

            if (response != null)
            {
                HandleResponse(response);
                return;
            }

            var @event = _eventFactory.Create(e.Message);

            if (@event != null)
            {
                await HandleEvent(@event);
                return;
            }

            System.Diagnostics.Debug.Fail("Don't know what to do with response: " + e.Message);
        }

        public void Dispose()
        {
            if (_webSocket != null)
            {
                if (_webSocket.State == WebSocketState.Open)
                    _webSocket.Close();

                _webSocket.Dispose();
            }
        }
    }
}
