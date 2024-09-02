using MasterDevs.ChromeDevTools.Protocol;
using System;

namespace MasterDevs.ChromeDevTools
{

    public interface ICommandResponse
    {
        long Id { get; }
        string Method { get; }
    }

    public sealed class CommandResponse<T> : ICommandResponse
        where T : ICommandResult
    {
        public long Id { get; set; }
        public string Method { get; set; } = null!;
        public T Result { get; set; } = default!;
    }
}