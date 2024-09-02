using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Preload
{
	/// <summary>
	/// Fired when a prefetch attempt is updated.
	/// </summary>
	[EventName(ProtocolName.Preload.PrefetchStatusUpdated)]
	[SupportedBy("Chrome")]
	public class PrefetchStatusUpdatedEventParams : IEventParams
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
