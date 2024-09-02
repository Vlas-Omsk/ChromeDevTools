using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Fired when the node should be inspected. This happens after call to `setInspectMode` or when
	/// user manually inspects an element.
	/// </summary>
	[EventName(ProtocolName.Overlay.InspectNodeRequested)]
	[SupportedBy("Chrome")]
	public class InspectNodeRequestedEventParams : IEventParams
	{
		/// <summary>
		/// Id of the node to inspect.
		/// </summary>
		public long BackendNodeId { get; set; }
	}
}
