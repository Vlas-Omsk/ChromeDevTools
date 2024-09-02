namespace MasterDevs.ChromeDevTools
{
    internal sealed class RemoteChromeSessionFactory
    {
        private readonly CommandFactory _commandFactory;
        private readonly CommandResponseFactory _commandResponseFactory;
        private readonly EventFactory _eventFactory;

        public RemoteChromeSessionFactory()
        {
            _commandFactory = new CommandFactory();
            _commandResponseFactory = new CommandResponseFactory(_commandFactory);
            _eventFactory = new EventFactory();
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
