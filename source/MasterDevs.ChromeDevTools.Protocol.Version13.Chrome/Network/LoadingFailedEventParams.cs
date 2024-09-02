using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when HTTP request has failed to load.
	/// </summary>
	[EventName(ProtocolName.Network.LoadingFailed)]
	[SupportedBy("Chrome")]
	public class LoadingFailedEventParams : IEventParams
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
		/// Resource type.
		/// </summary>
		public ResourceType Type { get; set; }
		/// <summary>
		/// User friendly error message.
		/// </summary>
		public string ErrorText { get; set; }
		/// <summary>
		/// True if loading was canceled.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Canceled { get; set; }
		/// <summary>
		/// The reason why loading was blocked, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BlockedReason BlockedReason { get; set; }
		/// <summary>
		/// The reason why loading was blocked by CORS, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CorsErrorStatus CorsErrorStatus { get; set; }
	}
}
