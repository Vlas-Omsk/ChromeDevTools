using MasterDevs.ChromeDevTools.Protocol;

namespace MasterDevs.ChromeDevTools.Remote
{
    internal interface ICommandResponse
    {
        long Id { get; }
    }

    internal sealed class CommandResponse<T> : ICommandResponse
        where T : ICommandResult
    {
        public long Id { get; set; }
        public string Method { get; set; } = null!;
        public T Result { get; set; } = default!;
    }

    internal class Error
    {
        public int Code { get; set; }
        public string? Message { get; set; } = null!;
    }

    internal sealed class ErrorResponse : ICommandResponse
    {
        public long Id { get; set; }
        public Error Error { get; set; } = null!;
    }
}