using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Represents the value serialiazed by the WebDriver BiDi specification
	/// https://w3c.github.io/webdriver-bidi.
	/// </summary>
	[SupportedBy("Chrome")]
	public class WebDriverValue
	{
		/// <summary>
		/// Type
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Value
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Value { get; set; }
		/// <summary>
		/// ObjectId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}
