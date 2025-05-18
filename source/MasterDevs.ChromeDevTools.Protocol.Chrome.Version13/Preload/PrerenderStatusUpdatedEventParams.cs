using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Preload
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
