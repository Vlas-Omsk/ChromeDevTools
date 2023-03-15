using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Information about font variation axes for variable fonts
	/// </summary>
	[SupportedBy("Chrome")]
	public class FontVariationAxis
	{
		/// <summary>
		/// The font-variation-setting tag (a.k.a. "axis tag").
		/// </summary>
		public string Tag { get; set; }
		/// <summary>
		/// Human-readable variation name in the default language (normally, "en").
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The minimum value (inclusive) the font supports for this tag.
		/// </summary>
		public double MinValue { get; set; }
		/// <summary>
		/// The maximum value (inclusive) the font supports for this tag.
		/// </summary>
		public double MaxValue { get; set; }
		/// <summary>
		/// The default value.
		/// </summary>
		public double DefaultValue { get; set; }
	}
}
