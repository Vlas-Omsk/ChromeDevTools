using System;

namespace MasterDevs.ChromeDevTools
{
    public class Error
    {
        public int Code { get; set; }
        public string? Message { get; set; } = null!;
    }

    internal sealed class ErrorResponse : ICommandResponse
    {
        public long Id { get; set; }
        public string Method
        {
            get => throw new NotSupportedException();
        }
        public Error Error { get; set; } = null!;
    }
}