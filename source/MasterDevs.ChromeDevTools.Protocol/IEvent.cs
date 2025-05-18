namespace MasterDevs.ChromeDevTools.Protocol
{
    public interface IEvent<T>
        where T : IEventParams
    {
        string SessionId { get; }
        T Params { get; }
    }
}