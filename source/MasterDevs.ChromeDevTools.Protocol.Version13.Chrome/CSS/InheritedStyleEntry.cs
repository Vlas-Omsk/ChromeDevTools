using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Inherited CSS rule collection from ancestor node.
	/// </summary>
	[SupportedBy("Chrome")]
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
