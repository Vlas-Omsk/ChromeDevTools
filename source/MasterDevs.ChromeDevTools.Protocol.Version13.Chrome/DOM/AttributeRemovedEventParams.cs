using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Fired when `Element`'s attribute is removed.
	/// </summary>
	[EventName(ProtocolName.DOM.AttributeRemoved)]
	[SupportedBy("Chrome")]
	public class AttributeRemovedEventParams : IEventParams
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
