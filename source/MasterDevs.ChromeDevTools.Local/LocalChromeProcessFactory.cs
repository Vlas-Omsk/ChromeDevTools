using MasterDevs.ChromeDevTools.Remote;
using Microsoft.Extensions.Logging;

namespace MasterDevs.ChromeDevTools.Local
{
    public sealed class LocalChromeProcessFactory
    {
        private readonly string _chromePath;
        private readonly ILoggerFactory _loggerFactory;
        private readonly RemoteChromeProcessFactory _remoteChromeProcessFactory;

        public LocalChromeProcessFactory(string chromePath, ILoggerFactory loggerFactory)
        {
            _chromePath = chromePath;
            _loggerFactory = loggerFactory;
            _remoteChromeProcessFactory = new RemoteChromeProcessFactory();
        }

        public IChromeProcess Create(ChromeProcessParameters parameters)
        {
            var chromeProcess = new LocalChromeProcess(
                _chromePath,
                parameters,
                _remoteChromeProcessFactory,
                _loggerFactory.CreateLogger<LocalChromeProcess>()
            );

            chromeProcess.Start();

            return chromeProcess;
        }
    }
}