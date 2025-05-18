using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Default font sizes.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FontSizes
	{
		/// <summary>
		/// Default standard font size.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Standard { get; set; }
		/// <summary>
		/// Default fixed font size.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Fixed { get; set; }
	}
}
