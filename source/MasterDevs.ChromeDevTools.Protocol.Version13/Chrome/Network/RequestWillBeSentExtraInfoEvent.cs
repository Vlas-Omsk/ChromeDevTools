using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when additional information about a requestWillBeSent event is available from the
	/// network stack. Not every requestWillBeSent event will have an additional
	/// requestWillBeSentExtraInfo fired for it, and there is no guarantee whether requestWillBeSent
	/// or requestWillBeSentExtraInfo will be fired first for the same request.
	/// </summary>
	[Event(ProtocolName.Network.RequestWillBeSentExtraInfo)]
	[SupportedBy("Chrome")]
	public class RequestWillBeSentExtraInfoEvent
	{
		/// <summary>
		/// Request identifier. Used to match this information to an existing requestWillBeSent event.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// A list of cookies potentially associated to the requested URL. This includes both cookies sent with
		/// the request and the ones not sent; the latter are distinguished by having blockedReason field set.
		/// </summary>
		public BlockedCookieWithReason[] AssociatedCookies { get; set; }
		/// <summary>
		/// Raw request headers as they will be sent over the wire.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// Connection timing information for the request.
		/// </summary>
		public ConnectTiming ConnectTiming { get; set; }
		/// <summary>
		/// The client security state set for the request.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ClientSecurityState ClientSecurityState { get; set; }
		/// <summary>
		/// Whether the site has partitioned cookies stored in a partition different than the current one.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? SiteHasCookieInOtherPartition { get; set; }
	}
}
