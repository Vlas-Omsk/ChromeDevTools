using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Local
{
    public class LocalChromeProcess : RemoteChromeProcess, ILocalChromeProcess
    {
        public LocalChromeProcess(
            IDirectoryCleaner directoryCleaner,
            string chromePath,
            ChromeProcessParameters parameters,
            IChromeSessionFactory sessionFactory
        ) : base("http://localhost:" + parameters.Port, sessionFactory)
        {
            DirectoryCleaner = directoryCleaner;
            ChromePath = chromePath;
            Parameters = parameters;
        }

        public IDirectoryCleaner DirectoryCleaner { get; }
        public string ChromePath { get; }
        public ChromeProcessParameters Parameters { get; }
        public string ProxyHost { get; set; }
        public int ProxyPort { get; set; }
        public bool EnableAutoProxyAuth { get; set; }
        public Process Process { get; private set; }

        public virtual void Start(CancellationToken cancellationToken)
        {
            var arguments = Parameters.Arguments;

            if (ProxyHost != null)
                arguments = $"--proxy-server=\"http://{ProxyHost}:{ProxyPort}\" " + arguments;

            Process = new Process()
            {
                StartInfo = new ProcessStartInfo(ChromePath, arguments)
            };

            if (!Process.Start())
                throw new Exception("Process exited with exit code " + Process.ExitCode);
        }

        public virtual void Close()
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

        private async Task<IntPtr> GetMainWindowHandle()
        {
            if (Process.MainWindowHandle == IntPtr.Zero)
            {
                await Task.Delay(1000).ConfigureAwait(false);

                SpinWait.SpinUntil(() => Process.MainWindowHandle != IntPtr.Zero);
            }

            return Process.MainWindowHandle;
        }
    }
}