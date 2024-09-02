using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Fired when frame has started loading.
	/// </summary>
	[EventName(ProtocolName.Page.FrameStartedLoading)]
	[SupportedBy("IOS")]
	public class FrameStartedLoadingEventParams : IEventParams
	{
		/// <summary>
		/// Id of the frame that has started loading.
		/// </summary>
		public string FrameId { get; set; }
	}
}
