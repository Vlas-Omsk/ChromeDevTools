using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Fired when <code>Container</code>'s child node count has changed.
	/// </summary>
	[EventName(ProtocolName.DOM.ChildNodeCountUpdated)]
	[SupportedBy("IOS")]
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
