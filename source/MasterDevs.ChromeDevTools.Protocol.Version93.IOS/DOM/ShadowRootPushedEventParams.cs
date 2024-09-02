using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Called when shadow root is pushed into the element.
	/// </summary>
	[EventName(ProtocolName.DOM.ShadowRootPushed)]
	[SupportedBy("IOS")]
	public class ShadowRootPushedEventParams : IEventParams
	{
		/// <summary>
		/// Host element id.
		/// </summary>
		public long HostId { get; set; }
		/// <summary>
		/// Shadow root.
		/// </summary>
		public Node Root { get; set; }
	}
}
