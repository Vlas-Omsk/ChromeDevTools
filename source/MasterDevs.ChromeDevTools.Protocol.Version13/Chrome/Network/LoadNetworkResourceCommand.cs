using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fetches the resource and returns the content.
	/// </summary>
	[Command(ProtocolName.Network.LoadNetworkResource)]
	[SupportedBy("Chrome")]
	public class LoadNetworkResourceCommand: IProtocolCommand<LoadNetworkResourceCommandResponse>
	{
		/// <summary>
		/// Frame id to get the resource for. Mandatory for frame targets, and
		/// should be omitted for worker targets.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
		/// <summary>
		/// URL of the resource to get content for.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Options for the request.
		/// </summary>
		public LoadNetworkResourceOptions Options { get; set; }
	}
}
