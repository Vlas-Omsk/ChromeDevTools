using System.Threading;

namespace MasterDevs.ChromeDevTools.Local
{
    public interface ILocalChromeProcess : IChromeProcess
    {
        void Start(CancellationToken cancellationToken);
        void Close();
    }
}
