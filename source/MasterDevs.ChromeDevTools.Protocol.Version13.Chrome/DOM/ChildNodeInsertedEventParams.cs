using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Mirrors `DOMNodeInserted` event.
	/// </summary>
	[EventName(ProtocolName.DOM.ChildNodeInserted)]
	[SupportedBy("Chrome")]
	public class ChildNodeInsertedEventParams : IEventParams
	{
		/// <summary>
		/// Id of the node that has changed.
		/// </summary>
		public long ParentNodeId { get; set; }
		/// <summary>
		/// Id of the previous sibling.
		/// </summary>
		public long PreviousNodeId { get; set; }
		/// <summary>
		/// Inserted node data.
		/// </summary>
		public Node Node { get; set; }
	}
}
