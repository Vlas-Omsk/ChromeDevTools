using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Fired when `Container`'s child node count has changed.
	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeCountUpdated)]
	[SupportedBy("Chrome")]
	public class ChildNodeCountUpdatedEvent
	{
		/// <summary>
		/// Id of the node that has changed.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// New node count.
		/// </summary>
		public long ChildNodeCount { get; set; }
	}
}
