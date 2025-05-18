using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
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
