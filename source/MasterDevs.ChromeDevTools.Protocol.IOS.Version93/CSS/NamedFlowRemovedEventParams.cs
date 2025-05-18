using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
{
	/// <summary>
	/// Fires when a Named Flow is removed: has no associated content nodes and regions.
	/// </summary>
	[EventName(ProtocolName.CSS.NamedFlowRemoved)]
	[SupportedBy("IOS")]
	public class NamedFlowRemovedEventParams : IEventParams
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
