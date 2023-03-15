using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	/// Fired when a prefetch attempt is updated.
	/// </summary>
	[Event(ProtocolName.Preload.PrefetchStatusUpdated)]
	[SupportedBy("Chrome")]
	public class PrefetchStatusUpdatedEvent
	{
		/// <summary>
		/// The frame id of the frame initiating prefetch.
		/// </summary>
		public string InitiatingFrameId { get; set; }
		/// <summary>
		/// PrefetchUrl
		/// </summary>
		public string PrefetchUrl { get; set; }
		/// <summary>
		/// Status
		/// </summary>
		public PreloadingStatus Status { get; set; }
	}
}
