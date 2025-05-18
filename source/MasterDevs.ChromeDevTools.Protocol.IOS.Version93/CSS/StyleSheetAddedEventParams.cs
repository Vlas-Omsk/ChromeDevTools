using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
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
