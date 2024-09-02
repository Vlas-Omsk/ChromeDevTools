using MasterDevs.ChromeDevTools.Protocol;
using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace MasterDevs.ChromeDevTools
{
    internal sealed class CommandFactory
    {
        private readonly ConcurrentDictionary<long, Type> _idTypeMap = new ConcurrentDictionary<long, Type>();
        private readonly ConcurrentDictionary<string, Type> _nameTypeMap = new ConcurrentDictionary<string, Type>();
        private long _count = 0;

        public Command<T> Create<T>(ICommandParams<T> @params)
            where T : ICommandResult
        {
            var command = new Command<T>()
            {
                Id = Interlocked.Increment(ref _count),
                Method = @params.MethodName,
                Params = @params
            };

            _idTypeMap.AddOrUpdate(command.Id, typeof(T), (key, value) => typeof(T));
            _nameTypeMap.AddOrUpdate(command.Method, typeof(T), (key, value) => typeof(T));

            return command;
        }

        public bool TryTakeCommandResultType(long? id, string? method, [NotNullWhen(true)] out Type? type)
        {
            if (id.HasValue && _idTypeMap.TryRemove(id.Value, out type))
                return true;

            if (method != null && _nameTypeMap.TryGetValue(method, out type))
                return true;

            type = null;
            return false;
        }
    }
}