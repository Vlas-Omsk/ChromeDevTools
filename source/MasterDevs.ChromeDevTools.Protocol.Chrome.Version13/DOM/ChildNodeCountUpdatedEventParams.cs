using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Fired when `Container`'s child node count has changed.
	/// </summary>
	[EventName(ProtocolName.DOM.ChildNodeCountUpdated)]
	[SupportedBy("Chrome")]
	public class ChildNodeCountUpdatedEventParams : IEventParams
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
