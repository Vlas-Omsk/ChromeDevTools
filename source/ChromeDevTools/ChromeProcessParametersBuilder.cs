using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MasterDevs.ChromeDevTools
{
    public sealed class ChromeProcessParametersBuilder
    {
        private static readonly string[] _reservedParameters = { "remote-debugging-port", "user-data-dir" };
        private readonly Dictionary<string, object> _parameters = new Dictionary<string, object>();

        public ChromeProcessParametersBuilder() : this(9222)
        {
        }

        public ChromeProcessParametersBuilder(int port) : this(port, GetRandomDirectory())
        {
        }

        public ChromeProcessParametersBuilder(int port, string userDataDirectory)
        {
            Port = port;
            UserDataDirectory = userDataDirectory;

            _parameters["remote-debugging-port"] = port;
            _parameters["user-data-dir"] = userDataDirectory;
            _parameters["bwsi"] = null;
            _parameters["no-first-run"] = null;
        }

        public int Port { get; }
        public string UserDataDirectory { get; }

        public ChromeProcessParametersBuilder SetParameter(string name)
        {
            return SetParameter(name, null);
        }

        public ChromeProcessParametersBuilder SetParameter(string name, object value)
        {
            if (Array.Exists(_reservedParameters, x => x == name))
                throw new InvalidOperationException("Cannot set reserved parameter");

            _parameters[name] = value;

            return this;
        }

        public ChromeProcessParametersBuilder SetHeadless()
        {
            return SetParameter("headless").SetParameter("disable-gpu");
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            var i = 0;

            foreach (var parameter in _parameters)
            {
                var parameterType = parameter.Value?.GetType();

                if (parameterType == typeof(string))
                    result.Append($"--{parameter.Key}=\"{parameter.Value}\"");
                else if (parameterType == typeof(int))
                    result.Append($"--{parameter.Key}={parameter.Value}");
                else if (parameterType == null)
                    result.Append($"--{parameter.Key}");
                else
                    throw new Exception("Invalid parameter type");

                i++;

                if (i != _parameters.Count)
                    result.Append(' ');
            }

            return result.ToString();
        }

        private static string GetRandomDirectory()
        {
            var path = Path.GetRandomFileName();
            var directoryInfo = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), path));

            return directoryInfo.FullName;
        }
    }
}
