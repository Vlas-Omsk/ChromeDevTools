namespace MasterDevs.ChromeDevTools
{
    public class ChromeSessionFactory : IChromeSessionFactory
    {
        private readonly ICommandFactory _commandFactory;
        private readonly ICommandResponseFactory _commandResponseFactory;
        private readonly IEventFactory _eventFactory;

        public ChromeSessionFactory(IMethodTypeMap methodTypeMap)
        {
            _commandFactory = new CommandFactory();
            _commandResponseFactory = new CommandResponseFactory(methodTypeMap, _commandFactory);
            _eventFactory = new EventFactory(methodTypeMap);
        }

        public ChromeSessionFactory(ICommandFactory commandFactory, ICommandResponseFactory commandResponseFactory, IEventFactory eventFactory)
        {
            _commandFactory = commandFactory;
            _commandResponseFactory = commandResponseFactory;
            _eventFactory = eventFactory;
        }

        public IChromeSession Create(string webSocketDebuggerUrl, string id)
        {
            return new ChromeSession(webSocketDebuggerUrl, id, _commandFactory, _commandResponseFactory, _eventFactory);
        }
    }
}
