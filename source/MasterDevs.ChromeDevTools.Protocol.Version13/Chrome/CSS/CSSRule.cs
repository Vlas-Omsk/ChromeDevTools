using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS rule representation.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSRule
	{
		/// <summary>
		/// The css style sheet identifier (absent for user agent stylesheet and user-specified
		/// stylesheet rules) this rule came from.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Rule selector data.
		/// </summary>
		public SelectorList SelectorList { get; set; }
		/// <summary>
		/// Parent stylesheet's origin.
		/// </summary>
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Associated style declaration.
		/// </summary>
		public CSSStyle Style { get; set; }
		/// <summary>
		/// Media list array (for rules involving media queries). The array enumerates media queries
		/// starting with the innermost one, going outwards.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSMedia[] Media { get; set; }
		/// <summary>
		/// Container query list array (for rules involving container queries).
		/// The array enumerates container queries starting with the innermost one, going outwards.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSContainerQuery[] ContainerQueries { get; set; }
		/// <summary>
		/// @supports CSS at-rule array.
		/// The array enumerates @supports at-rules starting with the innermost one, going outwards.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSSupports[] Supports { get; set; }
		/// <summary>
		/// Cascade layer array. Contains the layer hierarchy that this rule belongs to starting
		/// with the innermost layer and going outwards.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSLayer[] Layers { get; set; }
		/// <summary>
		/// @scope CSS at-rule array.
		/// The array enumerates @scope at-rules starting with the innermost one, going outwards.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSScope[] Scopes { get; set; }
	}
}
