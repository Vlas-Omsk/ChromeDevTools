namespace MasterDevs.ChromeDevTools
{
    internal sealed class RemoteChromeSessionFactory
    {
        private readonly CommandFactory _commandFactory;
        private readonly CommandResponseFactory _commandResponseFactory;
        private readonly EventFactory _eventFactory;

        public RemoteChromeSessionFactory(IProtocolTypeMap protocolTypeMap)
        {
            _commandFactory = new CommandFactory();
            _commandResponseFactory = new CommandResponseFactory(protocolTypeMap);
            _eventFactory = new EventFactory(protocolTypeMap);
        }

        public IChromeSession Create(string webSocketDebuggerUrl, string id)
        {
            return new RemoteChromeSession(
                webSocketDebuggerUrl,
                id,
                _commandFactory,
                _commandResponseFactory,
                _eventFactory
            );
        }
    }
}
