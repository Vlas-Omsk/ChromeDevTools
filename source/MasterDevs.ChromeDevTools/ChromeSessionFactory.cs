using MasterDevs.ChromeDevTools.Protocol;

namespace MasterDevs.ChromeDevTools
{
    public class ChromeSessionFactory : IChromeSessionFactory
    {
        private readonly ICommonCommandsExecutor _commandsExecutor;
        private readonly ICommandFactory _commandFactory;
        private readonly ICommandResponseFactory _commandResponseFactory;
        private readonly IEventFactory _eventFactory;

        public ChromeSessionFactory(IMethodTypeMap methodTypeMap, ICommonCommandsExecutor commandsExecutor)
        {
            _commandsExecutor = commandsExecutor;
            _commandFactory = new CommandFactory();
            _commandResponseFactory = new CommandResponseFactory(methodTypeMap, _commandFactory);
            _eventFactory = new EventFactory(methodTypeMap);
        }

        public ChromeSessionFactory(ICommonCommandsExecutor commandsExecutor, ICommandFactory commandFactory, ICommandResponseFactory commandResponseFactory, IEventFactory eventFactory)
        {
            _commandsExecutor = commandsExecutor;
            _commandFactory = commandFactory;
            _commandResponseFactory = commandResponseFactory;
            _eventFactory = eventFactory;
        }

        public IChromeSession Create(string webSocketDebuggerUrl, string id)
        {
            return new ChromeSession(
                webSocketDebuggerUrl,
                id,
                _commandsExecutor,
                _commandFactory,
                _commandResponseFactory,
                _eventFactory
            );
        }
    }
}
