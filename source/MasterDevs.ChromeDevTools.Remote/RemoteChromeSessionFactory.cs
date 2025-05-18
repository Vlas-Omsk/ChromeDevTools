namespace MasterDevs.ChromeDevTools.Remote
{
    internal sealed class RemoteChromeSessionFactory
    {
        private readonly CommandRequestFactory _commandRequestFactory;
        private readonly CommandResponseFactory _commandResponseFactory;
        private readonly EventFactory _eventFactory;

        public RemoteChromeSessionFactory()
        {
            _commandRequestFactory = new CommandRequestFactory();
            _commandResponseFactory = new CommandResponseFactory(_commandRequestFactory);
            _eventFactory = new EventFactory();
        }

        public IChromeSession Create(string webSocketDebuggerUrl)
        {
            return new RemoteChromeSession(
                webSocketDebuggerUrl,
                _commandRequestFactory,
                _commandResponseFactory,
                _eventFactory
            );
        }
    }
}
