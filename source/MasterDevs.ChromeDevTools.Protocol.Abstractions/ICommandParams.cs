namespace MasterDevs.ChromeDevTools.Protocol
{
    public interface ICommandParams<T> : IMethodParams
        where T : ICommandResult
    {
    }
}
