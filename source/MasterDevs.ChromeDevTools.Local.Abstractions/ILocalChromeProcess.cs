namespace MasterDevs.ChromeDevTools.Local
{
    public interface ILocalChromeProcess : IChromeProcess
    {
        void Start();
        void Close();
    }
}
