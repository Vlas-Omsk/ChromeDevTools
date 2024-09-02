using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when HTTP response is available.
	/// </summary>
	[EventName(ProtocolName.Network.ResponseReceived)]
	[SupportedBy("Chrome")]
	public class ResponseReceivedEventParams : IEventParams
	{
		/// <summary>
		/// Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Loader identifier. Empty string if the request is fetched from worker.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Resource type.
		/// </summary>
		public ResourceType Type { get; set; }
		/// <summary>
		/// Response data.
		/// </summary>
		public Response Response { get; set; }
		/// <summary>
		/// Indicates whether requestWillBeSentExtraInfo and responseReceivedExtraInfo events will be
		/// or were emitted for this request.
		/// </summary>
		public bool HasExtraInfo { get; set; }
		/// <summary>
		/// Frame identifier.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
