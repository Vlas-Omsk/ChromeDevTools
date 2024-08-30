using MasterDevs.ChromeDevTools.Protocol;

namespace MasterDevs.ChromeDevTools
{
    public sealed class Event<T>
        where T : IEventParams
    {
        public string Method { get; set; } = null!;
        public string SessionId { get; set; } = null!;
        public T Params { get; set; } = default!;
    }
}