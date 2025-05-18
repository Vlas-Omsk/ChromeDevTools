using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
{
	/// <summary>
	/// CSS rule collection for a single pseudo style.
	/// </summary>
	[SupportedBy("IOS")]
	public class InheritedStyleEntry
	{
		/// <summary>
		/// The ancestor node's inline style, if any, in the style inheritance chain.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSStyle InlineStyle { get; set; }
		/// <summary>
		/// Matches of CSS rules matching the ancestor node in the style inheritance chain.
		/// </summary>
		public RuleMatch[] MatchedCSSRules { get; set; }
	}
}
