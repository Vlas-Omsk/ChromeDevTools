using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Fired when the node should be highlighted. This happens after call to `setInspectMode`.
	/// </summary>
	[EventName(ProtocolName.Overlay.NodeHighlightRequested)]
	[SupportedBy("Chrome")]
	public class NodeHighlightRequestedEventParams : IEventParams
	{
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
