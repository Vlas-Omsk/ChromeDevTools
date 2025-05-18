using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MasterDevs.ChromeDevTools.Remote;
using Microsoft.Extensions.Logging;

namespace MasterDevs.ChromeDevTools.Local
{
    internal sealed class LocalChromeProcess : IChromeProcess
    {
        private readonly string _chromePath;
        private readonly ChromeProcessParameters _parameters;
        private readonly RemoteChromeProcessFactory _remoteChromeProcessFactory;
        private readonly ILogger<LocalChromeProcess> _logger;
        private Process? _process;
        private IChromeProcess? _remoteChromeProcess;

        public LocalChromeProcess(
            string chromePath,
            ChromeProcessParameters parameters,
            RemoteChromeProcessFactory remoteChromeProcessFactory,
            ILogger<LocalChromeProcess> logger
        )
        {
            _chromePath = chromePath;
            _parameters = parameters;
            _remoteChromeProcessFactory = remoteChromeProcessFactory;
            _logger = logger;
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
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                }
            };

            _process.OutputDataReceived += DataReceived;
            _process.ErrorDataReceived += DataReceived;

            if (!_process.Start())
                throw new Exception("Process exited with code " + _process.ExitCode);

            _process.BeginOutputReadLine();
            _process.BeginErrorReadLine();

            _remoteChromeProcess = _remoteChromeProcessFactory.Create(new Uri("http://localhost:" + _parameters.Port));
        }

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            _logger.LogDebug(e.Data);
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