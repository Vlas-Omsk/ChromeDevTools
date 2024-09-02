using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that AudioNodes are disconnected. The destination can be null, and it means all the outgoing connections from the source are disconnected.
	/// </summary>
	[EventName(ProtocolName.WebAudio.NodesDisconnected)]
	[SupportedBy("Chrome")]
	public class NodesDisconnectedEventParams : IEventParams
	{
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// SourceId
		/// </summary>
		public string SourceId { get; set; }
		/// <summary>
		/// DestinationId
		/// </summary>
		public string DestinationId { get; set; }
		/// <summary>
		/// SourceOutputIndex
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double SourceOutputIndex { get; set; }
		/// <summary>
		/// DestinationInputIndex
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DestinationInputIndex { get; set; }
	}
}
