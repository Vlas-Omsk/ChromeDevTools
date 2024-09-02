using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Returns requested styles for a DOM node identified by `nodeId`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetMatchedStylesForNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// Inline style for the specified DOM node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSStyle InlineStyle { get; set; }
		/// <summary>
		/// Attribute-defined element style (e.g. resulting from "width=20 height=100%").
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSStyle AttributesStyle { get; set; }
		/// <summary>
		/// CSS rules matching this node, from all applicable stylesheets.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RuleMatch[] MatchedCSSRules { get; set; }
		/// <summary>
		/// Pseudo style matches for this node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PseudoElementMatches[] PseudoElements { get; set; }
		/// <summary>
		/// A chain of inherited styles (from the immediate node parent up to the DOM tree root).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public InheritedStyleEntry[] Inherited { get; set; }
		/// <summary>
		/// A chain of inherited pseudo element styles (from the immediate node parent up to the DOM tree root).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public InheritedPseudoElementMatches[] InheritedPseudoElements { get; set; }
		/// <summary>
		/// A list of CSS keyframed animations matching this node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSKeyframesRule[] CssKeyframesRules { get; set; }
		/// <summary>
		/// Id of the first parent element that does not have display: contents.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ParentLayoutNodeId { get; set; }
	}
}
