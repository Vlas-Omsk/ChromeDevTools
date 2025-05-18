using MasterDevs.ChromeDevTools.Protocol;

namespace MasterDevs.ChromeDevTools.Remote
{
    internal sealed class CommandRequest<T>
        where T : ICommandResult
    {
        public long Id { get; set; }
        public string Method { get; set; } = null!;
        public string? SessionId { get; set; }
        public ICommand<T> Params { get; set; } = null!;
    }
}