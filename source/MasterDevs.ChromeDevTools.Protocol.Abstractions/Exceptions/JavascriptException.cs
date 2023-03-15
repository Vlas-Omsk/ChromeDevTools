using MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime;
using System;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public class JavascriptException : Exception
    {
        public JavascriptException(ExceptionDetails details) : base(details.Text)
        {
            Details = details;
        }

        public ExceptionDetails Details { get; }
    }
}
