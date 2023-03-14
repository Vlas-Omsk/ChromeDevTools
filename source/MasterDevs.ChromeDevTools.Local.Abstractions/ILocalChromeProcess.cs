using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Local
{
    public interface ILocalChromeProcess : IChromeProcess
    {
        Task Start();
        void Close();
    }
}
