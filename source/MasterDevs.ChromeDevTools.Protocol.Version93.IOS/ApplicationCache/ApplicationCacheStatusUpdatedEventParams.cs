using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.ApplicationCache
{
	[EventName(ProtocolName.ApplicationCache.ApplicationCacheStatusUpdated)]
	[SupportedBy("IOS")]
	public class ApplicationCacheStatusUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// Identifier of the frame containing document whose application cache updated status.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Manifest URL.
		/// </summary>
		public string ManifestURL { get; set; }
		/// <summary>
		/// Updated application cache status.
		/// </summary>
		public long Status { get; set; }
	}
}
