using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Fires whenever a web font is updated.  A non-empty font parameter indicates a successfully loaded
	/// web font.
	/// </summary>
	[EventName(ProtocolName.CSS.FontsUpdated)]
	[SupportedBy("Chrome")]
	public class FontsUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// The web font that has loaded.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FontFace Font { get; set; }
	}
}
