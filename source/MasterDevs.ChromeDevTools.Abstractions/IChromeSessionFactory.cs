namespace MasterDevs.ChromeDevTools
{
    public interface IChromeSessionFactory
    {
        IChromeSession Create(string webSocketDebuggerUrl, string id);
    }
}