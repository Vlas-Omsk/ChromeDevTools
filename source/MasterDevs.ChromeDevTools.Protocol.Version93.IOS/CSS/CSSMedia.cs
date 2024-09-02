using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// CSS media query descriptor.
	/// </summary>
	[SupportedBy("IOS")]
	public class CSSMedia
	{
		/// <summary>
		/// Media query text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Source of the media query: "mediaRule" if specified by a @media rule, "importRule" if specified by an @import rule, "linkedSheet" if specified by a "media" attribute in a linked stylesheet's LINK tag, "inlineSheet" if specified by a "media" attribute in an inline stylesheet's STYLE tag.
		/// </summary>
		public string Source { get; set; }
		/// <summary>
		/// URL of the document containing the media query description.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceURL { get; set; }
		/// <summary>
		/// Line in the document containing the media query (not defined for the "stylesheet" source).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? SourceLine { get; set; }
	}
}
