using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Fired when a renderer-initiated navigation is requested.
	/// Navigation may still be cancelled after the event is issued.
	/// </summary>
	[EventName(ProtocolName.Page.FrameRequestedNavigation)]
	[SupportedBy("Chrome")]
	public class FrameRequestedNavigationEventParams : IEventParams
	{
		/// <summary>
		/// Id of the frame that is being navigated.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// The reason for the navigation.
		/// </summary>
		public ClientNavigationReason Reason { get; set; }
		/// <summary>
		/// The destination URL for the requested navigation.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// The disposition for the navigation.
		/// </summary>
		public ClientNavigationDisposition Disposition { get; set; }
	}
}
