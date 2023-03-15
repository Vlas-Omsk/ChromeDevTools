using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	/// Fired when a prerender attempt is updated.
	/// </summary>
	[Event(ProtocolName.Preload.PrerenderStatusUpdated)]
	[SupportedBy("Chrome")]
	public class PrerenderStatusUpdatedEvent
	{
		/// <summary>
		/// The frame id of the frame initiating prerender.
		/// </summary>
		public string InitiatingFrameId { get; set; }
		/// <summary>
		/// PrerenderingUrl
		/// </summary>
		public string PrerenderingUrl { get; set; }
		/// <summary>
		/// Status
		/// </summary>
		public PreloadingStatus Status { get; set; }
	}
}
