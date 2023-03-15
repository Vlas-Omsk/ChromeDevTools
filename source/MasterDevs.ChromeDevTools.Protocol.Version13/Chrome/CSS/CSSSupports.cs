using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS Supports at-rule descriptor.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSSupports
	{
		/// <summary>
		/// Supports rule text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Whether the supports condition is satisfied.
		/// </summary>
		public bool Active { get; set; }
		/// <summary>
		/// The associated rule header range in the enclosing stylesheet (if
		/// available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Identifier of the stylesheet containing this object (if exists).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StyleSheetId { get; set; }
	}
}
