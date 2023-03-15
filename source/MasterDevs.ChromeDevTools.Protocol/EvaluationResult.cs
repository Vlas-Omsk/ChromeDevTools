namespace MasterDevs.ChromeDevTools.Protocol
{
    public sealed class EvaluationResult : IEvaluationResult
    {
        public EvaluationResult(object result, IEvaluationExceptionDetails exceptionDetails)
        {
            Result = result;
            ExceptionDetails = exceptionDetails;
        }

        public object Result { get; }
        public IEvaluationExceptionDetails ExceptionDetails { get; }
    }
}
