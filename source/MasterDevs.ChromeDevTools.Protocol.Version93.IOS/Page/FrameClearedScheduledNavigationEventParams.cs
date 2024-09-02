using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Fired when frame no longer has a scheduled navigation.
	/// </summary>
	[EventName(ProtocolName.Page.FrameClearedScheduledNavigation)]
	[SupportedBy("IOS")]
	public class FrameClearedScheduledNavigationEventParams : IEventParams
	{
		/// <summary>
		/// Id of the frame that has cleared its scheduled navigation.
		/// </summary>
		public string FrameId { get; set; }
	}
}
