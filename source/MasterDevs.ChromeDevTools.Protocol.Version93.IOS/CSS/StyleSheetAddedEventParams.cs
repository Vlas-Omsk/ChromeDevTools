using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is added.
	/// </summary>
	[EventName(ProtocolName.CSS.StyleSheetAdded)]
	[SupportedBy("IOS")]
	public class StyleSheetAddedEventParams : IEventParams
	{
		/// <summary>
		/// Added stylesheet metainfo.
		/// </summary>
		public CSSStyleSheetHeader Header { get; set; }
	}
}
