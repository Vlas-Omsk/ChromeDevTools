using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that two AudioNodes are connected.
	/// </summary>
	[EventName(ProtocolName.WebAudio.NodesConnected)]
	[SupportedBy("Chrome")]
	public class NodesConnectedEventParams : IEventParams
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
