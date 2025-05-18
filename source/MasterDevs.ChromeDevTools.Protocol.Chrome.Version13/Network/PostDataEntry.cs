using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Post data entry for HTTP request
	/// </summary>
	[SupportedBy("Chrome")]
	public class PostDataEntry
	{
		/// <summary>
		/// Bytes
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Bytes { get; set; }
	}
}
