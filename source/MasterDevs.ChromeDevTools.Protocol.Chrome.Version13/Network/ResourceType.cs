using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network{
	/// <summary>
	/// Resource type as it was perceived by the rendering engine.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ResourceType
	{
			Document,
			Stylesheet,
			Image,
			Media,
			Font,
			Script,
			TextTrack,
			XHR,
			Fetch,
			Prefetch,
			EventSource,
			WebSocket,
			Manifest,
			SignedExchange,
			Ping,
			CSPViolationReport,
			Preflight,
			Other,
	}
}
