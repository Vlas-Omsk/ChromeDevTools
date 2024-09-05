using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Fired when frame schedules a potential navigation.
	/// </summary>
	[EventName(ProtocolName.Page.FrameScheduledNavigation)]
	[SupportedBy("IOS")]
	public class FrameScheduledNavigationEventParams : IEventParams
	{
		/// <summary>
		/// Id of the frame that has scheduled a navigation.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Delay (in seconds) until the navigation is scheduled to begin. The navigation is not guaranteed to start.
		/// </summary>
		public double Delay { get; set; }
	}
}