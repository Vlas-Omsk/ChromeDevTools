using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Called when a pseudo element is removed from an element.
	/// </summary>
	[EventName(ProtocolName.DOM.PseudoElementRemoved)]
	[SupportedBy("Chrome")]
	public class PseudoElementRemovedEventParams : IEventParams
	{
		/// <summary>
		/// Pseudo element's parent element id.
		/// </summary>
		public long ParentId { get; set; }
		/// <summary>
		/// The removed pseudo element id.
		/// </summary>
		public long PseudoElementId { get; set; }
	}
}
