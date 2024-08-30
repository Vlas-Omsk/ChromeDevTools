using MasterDevs.ChromeDevTools.Protocol;
using System;

namespace MasterDevs.ChromeDevTools
{

    internal interface ICommandResponse
    {
        long Id { get; }
        string Method { get; }
    }
    
    internal sealed class CommandResponse<T> : ICommandResponse
        where T : ICommandResult
    {
        public long Id { get; set; }
        public string Method { get; set; } = null!;
        public T Result { get; set; } = default!;
    }

    internal sealed class ErrorResponse : ICommandResponse
    {
        public long Id { get; set; }
        public string Method
        {
            get => throw new NotSupportedException();
        }
        public Error Error { get; set; }
    }
}