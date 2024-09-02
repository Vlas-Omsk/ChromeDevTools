using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is removed.
	/// </summary>
	[EventName(ProtocolName.CSS.StyleSheetRemoved)]
	[SupportedBy("IOS")]
	public class StyleSheetRemovedEventParams : IEventParams
	{
		/// <summary>
		/// Identifier of the removed stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
