namespace MasterDevs.ChromeDevTools
{
    public class Event : IEvent
    {
        public string Method { get; set; }
        public string SessionId { get; set; }
    }

    public class Event<T> : Event
    {
        public T Params { get; set; }
    }
}