using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Called when a pseudo element is added to an element.
	/// </summary>
	[EventName(ProtocolName.DOM.PseudoElementAdded)]
	[SupportedBy("Chrome")]
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
