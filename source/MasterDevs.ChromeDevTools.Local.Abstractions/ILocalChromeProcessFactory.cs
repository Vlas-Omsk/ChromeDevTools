namespace MasterDevs.ChromeDevTools.Local
{
    public interface ILocalChromeProcessFactory
    {
        ILocalChromeProcess Create(ChromeProcessParameters parameters);
        ILocalChromeProcess Create(ChromeProcessParameters parameters, IDirectoryCleaner directoryCleaner);
    }
}
