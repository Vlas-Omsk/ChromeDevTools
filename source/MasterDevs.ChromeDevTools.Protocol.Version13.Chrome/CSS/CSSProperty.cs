using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// CSS property declaration data.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSProperty
	{
		/// <summary>
		/// The property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The property value.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Whether the property has "!important" annotation (implies `false` if absent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Important { get; set; }
		/// <summary>
		/// Whether the property is implicit (implies `false` if absent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Implicit { get; set; }
		/// <summary>
		/// The full property text as specified in the style.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Text { get; set; }
		/// <summary>
		/// Whether the property is understood by the browser (implies `true` if absent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ParsedOk { get; set; }
		/// <summary>
		/// Whether the property is disabled by the user (present for source-based properties only).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Disabled { get; set; }
		/// <summary>
		/// The entire property range in the enclosing style declaration (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Parsed longhand components of this property if it is a shorthand.
		/// This field will be empty if the given property is not a shorthand.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSProperty[] LonghandProperties { get; set; }
	}
}
