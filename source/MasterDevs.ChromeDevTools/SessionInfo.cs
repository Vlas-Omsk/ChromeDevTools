namespace MasterDevs.ChromeDevTools
{
    internal sealed class SessionInfo
    {
        public string Description { get; set; } = null!;
        public string DevtoolsFrontendUrl { get; set; } = null!;
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string WebSocketDebuggerUrl { get; set; } = null!;
    }
}