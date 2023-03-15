namespace MasterDevs.ChromeDevTools.Protocol
{
    public interface IEvaluationExceptionDetails
    {
        public string Text { get; }
        public long LineNumber { get; }
        public long ColumnNumber { get; }
    }
}
