using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CacheStorage
{
	/// <summary>
	/// Cached response
	/// </summary>
	[SupportedBy("Chrome")]
	public class CachedResponse
	{
		/// <summary>
		/// Entry content, base64-encoded. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string Body { get; set; }
	}
}
