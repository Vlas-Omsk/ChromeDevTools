using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools
{
    public class ChromeProcess : IChromeProcess
    {
        private readonly HttpClient _httpClient;
        private readonly IChromeSessionFactory _sessionFactory;

        public ChromeProcess(string remoteDebuggingUri, IChromeSessionFactory sessionFactory)
            : this(new Uri(remoteDebuggingUri), sessionFactory)
        {

        }

        public ChromeProcess(Uri remoteDebuggingUri, IChromeSessionFactory sessionFactory)
        {
            RemoteDebuggingUri = remoteDebuggingUri;

            _httpClient = new HttpClient
            {
                BaseAddress = RemoteDebuggingUri
            };
            _sessionFactory = sessionFactory;
        }

        public Uri RemoteDebuggingUri { get; }

        public virtual void Dispose()
        {
            _httpClient.Dispose();
        }

        public async Task<ChromeSessionInfo[]> GetSessionsRaw()
        {
            string json = await _httpClient.GetStringAsync("/json");

            return JsonConvert.DeserializeObject<ChromeSessionInfo[]>(json);
        }

        public async Task<ChromeSessionInfo> StartNewSessionRaw()
        {
            string json = await _httpClient.GetStringAsync("/json/new");

            return JsonConvert.DeserializeObject<ChromeSessionInfo>(json);
        }

        public async Task<IChromeSession> StartNewSession()
        {
            ChromeSessionInfo info = await StartNewSessionRaw();

            return _sessionFactory.Create(info.WebSocketDebuggerUrl, info.Id);
        }
    }
}