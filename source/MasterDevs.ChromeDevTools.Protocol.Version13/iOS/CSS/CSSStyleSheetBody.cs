using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// CSS stylesheet contents.
	/// </summary>
	[SupportedBy("iOS")]
	public class CSSStyleSheetBody
	{
		/// <summary>
		/// The stylesheet identifier.
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Stylesheet resource URL.
		/// </summary>
		public CSSRule[] Rules { get; set; }
		/// <summary>
		/// Stylesheet resource contents (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Text { get; set; }
	}
}
