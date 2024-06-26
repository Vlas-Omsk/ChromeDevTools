using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Match data for a CSS rule.
	/// </summary>
	[SupportedBy("iOS")]
	public class RuleMatch
	{
		/// <summary>
		/// CSS rule in the match.
		/// </summary>
		public CSSRule Rule { get; set; }
		/// <summary>
		/// Matching selector indices in the rule's selectorList selectors (0-based).
		/// </summary>
		public long[] MatchingSelectors { get; set; }
	}
}
