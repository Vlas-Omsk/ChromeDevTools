using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Data for a simple selector (these are delimited by commas in a selector list).
	/// </summary>
	[SupportedBy("Chrome")]
	public class Value
	{
		/// <summary>
		/// Value text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Value range in the underlying resource (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
	}
}
