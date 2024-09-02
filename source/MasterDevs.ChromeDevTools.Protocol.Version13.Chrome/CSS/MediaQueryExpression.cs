using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Media query expression descriptor.
	/// </summary>
	[SupportedBy("Chrome")]
	public class MediaQueryExpression
	{
		/// <summary>
		/// Media query expression value.
		/// </summary>
		public double Value { get; set; }
		/// <summary>
		/// Media query expression units.
		/// </summary>
		public string Unit { get; set; }
		/// <summary>
		/// Media query expression feature.
		/// </summary>
		public string Feature { get; set; }
		/// <summary>
		/// The associated range of the value text in the enclosing stylesheet (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange ValueRange { get; set; }
		/// <summary>
		/// Computed length of media query expression (if applicable).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ComputedLength { get; set; }
	}
}
