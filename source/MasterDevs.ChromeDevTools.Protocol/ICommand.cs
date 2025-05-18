namespace MasterDevs.ChromeDevTools.Protocol
{
    public interface ICommand<T>
        where T : ICommandResult
    {
        string MethodName { get; }
    }
}
