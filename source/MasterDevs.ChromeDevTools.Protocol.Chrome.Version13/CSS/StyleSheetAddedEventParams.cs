using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is added.
	/// </summary>
	[EventName(ProtocolName.CSS.StyleSheetAdded)]
	[SupportedBy("Chrome")]
	public class StyleSheetAddedEventParams : IEventParams
	{
		/// <summary>
		/// Added stylesheet metainfo.
		/// </summary>
		public CSSStyleSheetHeader Header { get; set; }
	}
}
