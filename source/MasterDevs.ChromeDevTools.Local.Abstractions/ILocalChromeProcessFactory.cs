namespace MasterDevs.ChromeDevTools.Local
{
    public interface ILocalChromeProcessFactory : IChromeProcessFactory
    {
        new ILocalChromeProcess Create(ChromeProcessParameters parameters);
        ILocalChromeProcess Create(ChromeProcessParameters parameters, IDirectoryCleaner directoryCleaner);
    }
}
