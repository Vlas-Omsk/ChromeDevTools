using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is removed.
	/// </summary>
	[EventName(ProtocolName.CSS.StyleSheetRemoved)]
	[SupportedBy("Chrome")]
	public class StyleSheetRemovedEventParams : IEventParams
	{
		/// <summary>
		/// Identifier of the removed stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
