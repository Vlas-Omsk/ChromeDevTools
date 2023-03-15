using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// HTTP request data.
	/// </summary>
	[SupportedBy("iOS")]
	public class Request
	{
		/// <summary>
		/// Request URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// HTTP request method.
		/// </summary>
		public string Method { get; set; }
		/// <summary>
		/// HTTP request headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// HTTP POST request data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PostData { get; set; }
	}
}
