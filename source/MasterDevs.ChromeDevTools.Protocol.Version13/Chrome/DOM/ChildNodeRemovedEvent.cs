using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Mirrors `DOMNodeRemoved` event.
	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeRemoved)]
	[SupportedBy("Chrome")]
	public class ChildNodeRemovedEvent
	{
		/// <summary>
		/// Parent id.
		/// </summary>
		public long ParentNodeId { get; set; }
		/// <summary>
		/// Id of the node that has been removed.
		/// </summary>
		public long NodeId { get; set; }
	}
}
