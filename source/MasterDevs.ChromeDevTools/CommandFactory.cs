using MasterDevs.ChromeDevTools.Protocol;
using System.Collections.Concurrent;
using System.Threading;

namespace MasterDevs.ChromeDevTools
{
    internal sealed class CommandFactory
    {
        private readonly ConcurrentDictionary<long, string> _methods = new ConcurrentDictionary<long, string>();
        private long _count = 0;

        public Command<T> Create<T>(ICommandParams<T> @params)
            where T : ICommandResult
        {
            var commandId = Interlocked.Increment(ref _count);
            var command = new Command<T>()
            {
                Id = commandId,
                Method = @params.GetMethod(),
                Params = @params
            };

            _methods.AddOrUpdate(commandId, command.Method, (key, value) => command.Method);

            return command;
        }

        public string? GetMethod(long id)
        {
            _methods.TryRemove(id, out var method);

            return method;
        }
    }
}