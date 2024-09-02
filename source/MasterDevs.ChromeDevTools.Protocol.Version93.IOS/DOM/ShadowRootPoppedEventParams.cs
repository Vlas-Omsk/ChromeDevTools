using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Called when shadow root is popped from the element.
	/// </summary>
	[EventName(ProtocolName.DOM.ShadowRootPopped)]
	[SupportedBy("IOS")]
	public class ShadowRootPoppedEventParams : IEventParams
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
