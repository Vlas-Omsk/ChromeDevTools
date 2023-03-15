using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Fired when HTTP request has been served from memory cache.
	/// </summary>
	[Event(ProtocolName.Network.RequestServedFromMemoryCache)]
	[SupportedBy("iOS")]
	public class RequestServedFromMemoryCacheEvent
	{
		/// <summary>
		/// Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Frame identifier.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Loader identifier.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// URL of the document this request is loaded for.
		/// </summary>
		public string DocumentURL { get; set; }
		/// <summary>
		/// Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Request initiator.
		/// </summary>
		public Initiator Initiator { get; set; }
		/// <summary>
		/// Cached resource data.
		/// </summary>
		public CachedResource Resource { get; set; }
	}
}
