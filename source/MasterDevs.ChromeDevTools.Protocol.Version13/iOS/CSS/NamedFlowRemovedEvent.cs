using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Fires when a Named Flow is removed: has no associated content nodes and regions.
	/// </summary>
	[Event(ProtocolName.CSS.NamedFlowRemoved)]
	[SupportedBy("iOS")]
	public class NamedFlowRemovedEvent
	{
		/// <summary>
		/// The document node id.
		/// </summary>
		public long DocumentNodeId { get; set; }
		/// <summary>
		/// Identifier of the removed Named Flow.
		/// </summary>
		public string FlowName { get; set; }
	}
}
