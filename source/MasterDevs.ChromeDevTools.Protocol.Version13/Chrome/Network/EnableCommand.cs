using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Enables network tracking, network events will now be delivered to the client.
	/// </summary>
	[Command(ProtocolName.Network.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: IProtocolCommand<EnableCommandResponse>
	{
		/// <summary>
		/// Buffer size in bytes to use when preserving network payloads (XHRs, etc).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxTotalBufferSize { get; set; }
		/// <summary>
		/// Per-resource buffer size in bytes to use when preserving network payloads (XHRs, etc).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxResourceBufferSize { get; set; }
		/// <summary>
		/// Longest post body size (in bytes) that would be included in requestWillBeSent notification
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxPostDataSize { get; set; }
	}
}
