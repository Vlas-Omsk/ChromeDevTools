using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Generic font families collection.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FontFamilies
	{
		/// <summary>
		/// The standard font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Standard { get; set; }
		/// <summary>
		/// The fixed font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Fixed { get; set; }
		/// <summary>
		/// The serif font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Serif { get; set; }
		/// <summary>
		/// The sansSerif font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SansSerif { get; set; }
		/// <summary>
		/// The cursive font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Cursive { get; set; }
		/// <summary>
		/// The fantasy font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Fantasy { get; set; }
		/// <summary>
		/// The math font-family.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Math { get; set; }
	}
}
