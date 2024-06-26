using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Called when a pseudo element is added to an element.
	/// </summary>
	[Event(ProtocolName.DOM.PseudoElementAdded)]
	[SupportedBy("iOS")]
	public class PseudoElementAddedEvent
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
