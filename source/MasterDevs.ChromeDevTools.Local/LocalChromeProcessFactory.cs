namespace MasterDevs.ChromeDevTools.Local
{
    public sealed class LocalChromeProcessFactory
    {
        private readonly string _chromePath;
        private readonly RemoteChromeProcessFactory _remoteChromeProcessFactory;

        public LocalChromeProcessFactory(string chromePath)
        {
            _chromePath = chromePath;
            _remoteChromeProcessFactory = new RemoteChromeProcessFactory();
        }

        public IChromeProcess Create(ChromeProcessParameters parameters)
        {
            var chromeProcess = new LocalChromeProcess(
                _chromePath,
                parameters,
                _remoteChromeProcessFactory
            );

            chromeProcess.Start();

            return chromeProcess;
        }
    }
}