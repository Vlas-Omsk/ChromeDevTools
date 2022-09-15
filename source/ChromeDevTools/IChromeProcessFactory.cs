namespace MasterDevs.ChromeDevTools
{
    public interface IChromeProcessFactory
    {
        IChromeProcess Create(ChromeProcessParametersBuilder parameters);
    }
}