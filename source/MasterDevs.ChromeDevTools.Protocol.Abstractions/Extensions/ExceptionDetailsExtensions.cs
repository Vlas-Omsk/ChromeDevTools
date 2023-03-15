namespace MasterDevs.ChromeDevTools.Protocol
{
    public static class ExceptionDetailsExtensions
    {
        public static void Throw(this IEvaluationExceptionDetails self)
        {
            throw new JavascriptException(self);
        }
    }
}
