using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Fired when frame has stopped loading.
	/// </summary>
	[EventName(ProtocolName.Page.FrameStoppedLoading)]
	[SupportedBy("IOS")]
	public class FrameStoppedLoadingEventParams : IEventParams
	{
		/// <summary>
		/// Id of the frame that has stopped loading.
		/// </summary>
		public string FrameId { get; set; }
	}
}
