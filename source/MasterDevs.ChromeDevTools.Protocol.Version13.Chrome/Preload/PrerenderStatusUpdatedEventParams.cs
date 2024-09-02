using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Preload
{
	/// <summary>
	/// Fired when a prerender attempt is updated.
	/// </summary>
	[EventName(ProtocolName.Preload.PrerenderStatusUpdated)]
	[SupportedBy("Chrome")]
	public class PrerenderStatusUpdatedEventParams : IEventParams
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
