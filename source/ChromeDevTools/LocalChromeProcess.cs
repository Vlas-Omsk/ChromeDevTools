using System.Diagnostics;

namespace MasterDevs.ChromeDevTools
{
    public class LocalChromeProcess : RemoteChromeProcess
    {
        public LocalChromeProcess(
            IDirectoryCleaner directoryCleaner,
            string chromePath,
            ChromeProcessParameters parameters,
            IChromeSessionFactory sessionFactory
        )
            : base("http://localhost:" + parameters.Port, sessionFactory)
        {
            DirectoryCleaner = directoryCleaner;
            Parameters = parameters;
            Process = new Process()
            {
                StartInfo = new ProcessStartInfo(chromePath, parameters.Parameters)
            };
        }

        public IDirectoryCleaner DirectoryCleaner { get; }
        public ChromeProcessParameters Parameters { get; }
        public Process Process { get; }

        public void Start()
        {
            Process.Start();
        }

        public void Close()
        {
            Process.Kill();
            Process.WaitForExit();
        }

        public override void Dispose()
        {
            base.Dispose();

            Close();
            DirectoryCleaner.Delete(Parameters.UserDataDirectory);
        }
    }
}