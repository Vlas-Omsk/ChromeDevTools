using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that an AudioNode is connected to an AudioParam.
	/// </summary>
	[Event(ProtocolName.WebAudio.NodeParamConnected)]
	[SupportedBy("Chrome")]
	public class NodeParamConnectedEvent
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
	}
}
