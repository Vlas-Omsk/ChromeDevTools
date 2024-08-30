using MasterDevs.ChromeDevTools.Protocol;

namespace MasterDevs.ChromeDevTools
{
    internal sealed class Command<T>
        where T : ICommandResult
    {
        public long Id { get; set; }
        public string Method { get; set; } = null!;
        public string? SessionId { get; set; }
        public ICommandParams<T> Params { get; set; } = null!;
    }
}