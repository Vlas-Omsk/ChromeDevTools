namespace MasterDevs.ChromeDevTools.Protocol
{
    public interface ICommandParams<T>
        where T : ICommandResult
    {
        string MethodName { get; }
    }
}
