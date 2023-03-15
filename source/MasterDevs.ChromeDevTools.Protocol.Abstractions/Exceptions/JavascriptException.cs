using System;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public class JavascriptException : Exception
    {
        public JavascriptException(IEvaluationExceptionDetails exceptionDetails) : base(exceptionDetails.Text)
        {
            ExceptionDetails = exceptionDetails;
        }

        public IEvaluationExceptionDetails ExceptionDetails { get; }
    }
}
