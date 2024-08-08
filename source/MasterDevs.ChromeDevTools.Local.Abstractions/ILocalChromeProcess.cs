using System.Threading;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Local
{
    public interface ILocalChromeProcess : IChromeProcess
    {
        Task Start(CancellationToken cancellationToken);
        void Close();
    }
}
