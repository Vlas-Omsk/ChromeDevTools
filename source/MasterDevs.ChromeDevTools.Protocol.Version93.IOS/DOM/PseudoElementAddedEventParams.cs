using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Called when a pseudo element is added to an element.
	/// </summary>
	[EventName(ProtocolName.DOM.PseudoElementAdded)]
	[SupportedBy("IOS")]
	public class PseudoElementAddedEventParams : IEventParams
	{
		/// <summary>
		/// Pseudo element's parent element id.
		/// </summary>
		public long ParentId { get; set; }
		/// <summary>
		/// The added pseudo element.
		/// </summary>
		public Node PseudoElement { get; set; }
	}
}