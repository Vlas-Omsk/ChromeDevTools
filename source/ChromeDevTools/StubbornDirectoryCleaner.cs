using System.IO;
using System.Threading;

namespace MasterDevs.ChromeDevTools
{
    public class StubbornDirectoryCleaner : IDirectoryCleaner
    {
        public void Delete(string directory)
        {
            while (true)
            {
                try
                {
                    Directory.Delete(directory, true);
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