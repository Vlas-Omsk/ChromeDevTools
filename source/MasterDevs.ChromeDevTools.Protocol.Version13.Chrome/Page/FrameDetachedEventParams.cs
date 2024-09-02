using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Fired when frame has been detached from its parent.
	/// </summary>
	[EventName(ProtocolName.Page.FrameDetached)]
	[SupportedBy("Chrome")]
	public class FrameDetachedEventParams : IEventParams
	{
		/// <summary>
		/// Id of the frame that has been detached.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Reason
		/// </summary>
		public string Reason { get; set; }
	}
}
