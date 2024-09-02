using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Fired when frame has been attached to its parent.
	/// </summary>
	[EventName(ProtocolName.Page.FrameAttached)]
	[SupportedBy("Chrome")]
	public class FrameAttachedEventParams : IEventParams
	{
		/// <summary>
		/// Id of the frame that has been attached.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Parent frame identifier.
		/// </summary>
		public string ParentFrameId { get; set; }
		/// <summary>
		/// JavaScript stack trace of when frame was attached, only set if frame initiated from script.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace Stack { get; set; }
	}
}
