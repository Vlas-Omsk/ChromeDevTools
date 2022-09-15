using System;
using System.Diagnostics;

namespace MasterDevs.ChromeDevTools
{
    public class ChromeProcessFactory : IChromeProcessFactory
    {
        public IDirectoryCleaner DirectoryCleaner { get; set; }
        public string ChromePath { get; }

        public ChromeProcessFactory(IDirectoryCleaner directoryCleaner, string chromePath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
        {
            DirectoryCleaner = directoryCleaner;
            ChromePath = chromePath;
        }

        public IChromeProcess Create(ChromeProcessParametersBuilder parameters)
        {
            var processStartInfo = new ProcessStartInfo(ChromePath, parameters.ToString());
            var chromeProcess = Process.Start(processStartInfo);

            string remoteDebuggingUrl = "http://localhost:" + parameters.Port;
            return new LocalChromeProcess(new Uri(remoteDebuggingUrl), () => DirectoryCleaner.Delete(parameters.UserDataDirectory), chromeProcess);
        }
    }
}