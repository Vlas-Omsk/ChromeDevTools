namespace MasterDevs.ChromeDevTools.Protocol
{
    public interface IEvaluationResult
    {
        public object Result { get; }
        public IEvaluationExceptionDetails ExceptionDetails { get; }
    }
}
