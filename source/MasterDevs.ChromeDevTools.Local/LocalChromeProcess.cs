using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Local
{
    internal sealed class LocalChromeProcess : IChromeProcess
    {
        private readonly string _chromePath;
        private readonly ChromeProcessParameters _parameters;
        private readonly RemoteChromeProcessFactory _remoteChromeProcessFactory;
        private Process? _process;
        private IChromeProcess? _remoteChromeProcess;

        public LocalChromeProcess(
            string chromePath,
            ChromeProcessParameters parameters,
            RemoteChromeProcessFactory remoteChromeProcessFactory
        )
        {
            _chromePath = chromePath;
            _parameters = parameters;
            _remoteChromeProcessFactory = remoteChromeProcessFactory;
        }

        public Task<IEnumerable<IChromeSessionConnector>> GetSessionsAsync()
        {
            if (_remoteChromeProcess == null)
                throw new InvalidOperationException("Process not started");

            return _remoteChromeProcess.GetSessionsAsync();
        }

        public Task<IChromeSessionConnector> StartNewSessionAsync()
        {
            if (_remoteChromeProcess == null)
                throw new InvalidOperationException("Process not started");

            return _remoteChromeProcess.StartNewSessionAsync();
        }

        internal void Start()
        {
            _process = new Process()
            {
                StartInfo = new ProcessStartInfo(_chromePath, _parameters.Arguments)
            };

            if (!_process.Start())
                throw new Exception("Process exited with code " + _process.ExitCode);

            _remoteChromeProcess = _remoteChromeProcessFactory.Create(new Uri("http://localhost:" + _parameters.Port));
        }

        private void Close()
        {
            _remoteChromeProcess?.Dispose();

            if (_process != null)
            {
                _process.Kill();
                _process.WaitForExit();
            }
        }

        public void Dispose()
        {
            Close();

            while (true)
            {
                try
                {
                    Directory.Delete(_parameters.UserDataDirectory, true);
                    return;
                }
                catch
                {
                    Thread.Sleep(500);
                }
            }
        }
    }
}