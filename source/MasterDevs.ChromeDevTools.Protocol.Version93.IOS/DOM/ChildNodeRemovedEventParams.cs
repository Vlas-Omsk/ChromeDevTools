using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Mirrors <code>DOMNodeRemoved</code> event.
	/// </summary>
	[EventName(ProtocolName.DOM.ChildNodeRemoved)]
	[SupportedBy("IOS")]
	public class ChildNodeRemovedEventParams : IEventParams
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
