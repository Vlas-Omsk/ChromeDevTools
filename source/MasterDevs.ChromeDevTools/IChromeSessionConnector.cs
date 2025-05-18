using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeSessionConnector
    {
        string Id { get; }
        string Title { get; }
        string Description { get; }
        string Type { get; }
        string Url { get; }

        Task<IChromeSession> ConnectAsync();
    }
}
