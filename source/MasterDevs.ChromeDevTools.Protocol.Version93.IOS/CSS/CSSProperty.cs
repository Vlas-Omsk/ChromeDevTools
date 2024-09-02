using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// CSS style effective visual dimensions and source offsets.
	/// </summary>
	[SupportedBy("IOS")]
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
		/// The property priority (implies "" if absent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Priority { get; set; }
		/// <summary>
		/// Whether the property is implicit (implies <code>false</code> if absent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Implicit { get; set; }
		/// <summary>
		/// The full property text as specified in the style.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Text { get; set; }
		/// <summary>
		/// Whether the property is understood by the browser (implies <code>true</code> if absent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ParsedOk { get; set; }
		/// <summary>
		/// Whether the property is active or disabled.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSPropertyStatus Status { get; set; }
		/// <summary>
		/// The entire property range in the enclosing style declaration (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
	}
}
