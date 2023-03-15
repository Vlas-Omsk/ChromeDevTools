using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Called when shadow root is pushed into the element.
	/// </summary>
	[Event(ProtocolName.DOM.ShadowRootPushed)]
	[SupportedBy("iOS")]
	public class ShadowRootPushedEvent
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
