using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Fired when `Element`'s attribute is modified.
	/// </summary>
	[EventName(ProtocolName.DOM.AttributeModified)]
	[SupportedBy("Chrome")]
	public class AttributeModifiedEventParams : IEventParams
	{
		/// <summary>
		/// Id of the node that has changed.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Attribute name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Attribute value.
		/// </summary>
		public string Value { get; set; }
	}
}
