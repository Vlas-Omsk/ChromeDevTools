using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Fired when <code>Element</code>'s attribute is removed.
	/// </summary>
	[EventName(ProtocolName.DOM.AttributeRemoved)]
	[SupportedBy("IOS")]
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
