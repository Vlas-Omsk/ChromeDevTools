using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Fired whenever a stylesheet is changed as a result of the client operation.
	/// </summary>
	[EventName(ProtocolName.CSS.StyleSheetChanged)]
	[SupportedBy("Chrome")]
	public class StyleSheetChangedEventParams : IEventParams
	{
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
