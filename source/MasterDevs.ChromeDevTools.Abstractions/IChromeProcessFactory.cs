namespace MasterDevs.ChromeDevTools
{
    public interface IChromeProcessFactory
    {
        IChromeProcess Create(string remoteDebuggingUri);
    }
}