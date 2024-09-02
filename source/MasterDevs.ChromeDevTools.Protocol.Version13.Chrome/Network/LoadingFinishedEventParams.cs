using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when HTTP request has finished loading.
	/// </summary>
	[EventName(ProtocolName.Network.LoadingFinished)]
	[SupportedBy("Chrome")]
	public class LoadingFinishedEventParams : IEventParams
	{
		/// <summary>
		/// Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Total number of bytes received for this request.
		/// </summary>
		public double EncodedDataLength { get; set; }
		/// <summary>
		/// Set when 1) response was blocked by Cross-Origin Read Blocking and also
		/// 2) this needs to be reported to the DevTools console.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShouldReportCorbBlocking { get; set; }
	}
}
