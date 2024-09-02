using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when page is about to send HTTP request.
	/// </summary>
	[EventName(ProtocolName.Network.RequestWillBeSent)]
	[SupportedBy("Chrome")]
	public class RequestWillBeSentEventParams : IEventParams
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
		/// URL of the document this request is loaded for.
		/// </summary>
		public string DocumentURL { get; set; }
		/// <summary>
		/// Request data.
		/// </summary>
		public Request Request { get; set; }
		/// <summary>
		/// Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Timestamp.
		/// </summary>
		public double WallTime { get; set; }
		/// <summary>
		/// Request initiator.
		/// </summary>
		public Initiator Initiator { get; set; }
		/// <summary>
		/// In the case that redirectResponse is populated, this flag indicates whether
		/// requestWillBeSentExtraInfo and responseReceivedExtraInfo events will be or were emitted
		/// for the request which was just redirected.
		/// </summary>
		public bool RedirectHasExtraInfo { get; set; }
		/// <summary>
		/// Redirect response data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Response RedirectResponse { get; set; }
		/// <summary>
		/// Type of this resource.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ResourceType Type { get; set; }
		/// <summary>
		/// Frame identifier.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
		/// <summary>
		/// Whether the request is initiated by a user gesture. Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasUserGesture { get; set; }
	}
}
