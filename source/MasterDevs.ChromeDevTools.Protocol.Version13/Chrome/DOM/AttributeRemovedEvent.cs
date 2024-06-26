using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Fired when `Element`'s attribute is removed.
	/// </summary>
	[Event(ProtocolName.DOM.AttributeRemoved)]
	[SupportedBy("Chrome")]
	public class AttributeRemovedEvent
	{
		/// <summary>
		/// Id of the node that has changed.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// A ttribute name.
		/// </summary>
		public string Name { get; set; }
	}
}
