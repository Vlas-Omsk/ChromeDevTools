using MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public static class ExceptionDetailsExtensions
    {
        public static void Throw(this ExceptionDetails self)
        {
            throw new JavascriptException(self);
        }
    }
}
