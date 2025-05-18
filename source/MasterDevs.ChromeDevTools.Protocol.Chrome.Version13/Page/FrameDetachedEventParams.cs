using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
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
