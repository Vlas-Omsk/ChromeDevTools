using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Activates emulation of network conditions.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EmulateNetworkConditionsCommandParams: ICommandParams<EmulateNetworkConditionsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.EmulateNetworkConditions;
		/// <summary>
		/// True to emulate internet disconnection.
		/// </summary>
		public bool Offline { get; set; }
		/// <summary>
		/// Minimum latency from request sent to response headers received (ms).
		/// </summary>
		public double Latency { get; set; }
		/// <summary>
		/// Maximal aggregated download throughput (bytes/sec). -1 disables download throttling.
		/// </summary>
		public double DownloadThroughput { get; set; }
		/// <summary>
		/// Maximal aggregated upload throughput (bytes/sec).  -1 disables upload throttling.
		/// </summary>
		public double UploadThroughput { get; set; }
		/// <summary>
		/// Connection type if known.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ConnectionType { get; set; }
	}
}
