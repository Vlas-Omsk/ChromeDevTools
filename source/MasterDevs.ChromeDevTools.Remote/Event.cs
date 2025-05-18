using MasterDevs.ChromeDevTools.Protocol;

namespace MasterDevs.ChromeDevTools.Remote
{
    public interface IEvent
    {
        string Method { get; }
        string SessionId { get; }
    }

    public sealed class Event<T> : IEvent<T>, IEvent
        where T : IEventParams
    {
        public string Method { get; set; } = null!;
        public string SessionId { get; set; } = null!;
        public T Params { get; set; } = default!;
    }
}
