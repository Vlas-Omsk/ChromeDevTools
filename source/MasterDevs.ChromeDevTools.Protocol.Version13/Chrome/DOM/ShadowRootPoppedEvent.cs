using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Called when shadow root is popped from the element.
	/// </summary>
	[Event(ProtocolName.DOM.ShadowRootPopped)]
	[SupportedBy("Chrome")]
	public class ShadowRootPoppedEvent
	{
		/// <summary>
		/// Host element id.
		/// </summary>
		public long HostId { get; set; }
		/// <summary>
		/// Shadow root id.
		/// </summary>
		public long RootId { get; set; }
	}
}
