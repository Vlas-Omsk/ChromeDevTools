using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Fired when backend wants to provide client with the missing DOM structure. This happens upon most of the calls requesting node ids.
	/// </summary>
	[EventName(ProtocolName.DOM.SetChildNodes)]
	[SupportedBy("IOS")]
	public class SetChildNodesEventParams : IEventParams
	{
		/// <summary>
		/// Parent node id to populate with children.
		/// </summary>
		public long ParentId { get; set; }
		/// <summary>
		/// Child nodes array.
		/// </summary>
		public Node[] Nodes { get; set; }
	}
}
