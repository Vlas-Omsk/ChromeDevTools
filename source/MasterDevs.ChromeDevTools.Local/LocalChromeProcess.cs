using MasterDevs.ChromeDevTools.Local.Windows;
using MasterDevs.ChromeDevTools.Protocol;
using MasterDevs.ChromeDevTools.Protocol.Chrome.Page;
using PinkNet;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Local
{
    public class LocalChromeProcess : ChromeProcess, ILocalChromeProcess
    {
        private const int _inputDelay = 100;

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
        public Proxy Proxy { get; set; }
        public bool EnableAutoProxyAuth { get; set; }
        public Process Process { get; private set; }

        public virtual async Task Start()
        {
            var arguments = Parameters.Arguments;

            if (Proxy != null)
                arguments = $"--proxy-server=\"{Proxy.GetUri(false)}\" " + arguments;

            Process = new Process()
            {
                StartInfo = new ProcessStartInfo(ChromePath, arguments)
            };

            Process.Start();

            await ConfigureProxy();
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
                await Task.Delay(1000);

                SpinWait.SpinUntil(() => Process.MainWindowHandle != IntPtr.Zero);
            }

            return Process.MainWindowHandle;
        }

        private async Task ConfigureProxy()
        {
            if (!EnableAutoProxyAuth || Proxy == null || Proxy.HasCredentials == false)
                return;

            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                throw new PlatformNotSupportedException("EnableAutoProxyAuth only available on windows platform");

            //if (HideChromeWindow)
            //{
            //    if (!Win32.SetWindowPos(localChromeProcess.Process.MainWindowHandle, new IntPtr(1), -1000, -1000, 0, 0, 0/*0x0080*/))
            //        throw new Win32Exception();
            //}

            var mainWindowHandle = await GetMainWindowHandle();
            var chromeSession = await StartNewSession();
            var input = new Input(_inputDelay);

            await chromeSession.SendAsync(new NavigateCommand()
            {
                Url = "https://microsoft.com/"
            });

            if (!Win32.SetForegroundWindow(mainWindowHandle))
                throw new Win32Exception();

            if (!Win32.GetWindowRect(mainWindowHandle, out Win32.RECT rect))
                throw new Win32Exception();

            var centerX = rect.Left + (rect.Right - rect.Left) / 2;

            // Set input focus in 'Username' field
            await input.MouseLeftClick(centerX, rect.Top + 205);

            await Task.Delay(_inputDelay);

            // Paste username
            Clipboard.SetText(Proxy.Username);
            await input.SendPasteCommand();

            await Task.Delay(_inputDelay);

            // Set input focus in 'Password' field
            await input.MouseLeftClick(centerX, rect.Top + 250);

            Thread.Sleep(100);

            // Paste password
            Clipboard.SetText(Proxy.Password);
            await input.SendPasteCommand();

            Thread.Sleep(100);

            // Click on 'Continue'
            await input.MouseLeftClick(centerX + 100, rect.Top + 310);

            chromeSession.WaitWhile("window.cas != null", TimeSpan.FromMinutes(1));

            await chromeSession.Close();
        }
    }
}