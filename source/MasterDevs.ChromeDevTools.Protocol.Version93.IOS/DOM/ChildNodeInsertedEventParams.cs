using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Mirrors <code>DOMNodeInserted</code> event.
	/// </summary>
	[EventName(ProtocolName.DOM.ChildNodeInserted)]
	[SupportedBy("IOS")]
	public class ChildNodeInsertedEventParams : IEventParams
	{
		/// <summary>
		/// Id of the node that has changed.
		/// </summary>
		public long ParentNodeId { get; set; }
		/// <summary>
		/// If of the previous siblint.
		/// </summary>
		public long PreviousNodeId { get; set; }
		/// <summary>
		/// Inserted node data.
		/// </summary>
		public Node Node { get; set; }
	}
}
