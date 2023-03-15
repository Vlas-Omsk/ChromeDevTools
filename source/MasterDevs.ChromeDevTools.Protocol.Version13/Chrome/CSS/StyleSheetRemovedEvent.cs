using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is removed.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetRemoved)]
	[SupportedBy("Chrome")]
	public class StyleSheetRemovedEvent
	{
		/// <summary>
		/// Identifier of the removed stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
