using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Data entry.
	/// </summary>
	[SupportedBy("Chrome")]
	public class DataEntry
	{
		/// <summary>
		/// Request URL.
		/// </summary>
		public string RequestURL { get; set; }
		/// <summary>
		/// Request method.
		/// </summary>
		public string RequestMethod { get; set; }
		/// <summary>
		/// Request headers
		/// </summary>
		public Header[] RequestHeaders { get; set; }
		/// <summary>
		/// Number of seconds since epoch.
		/// </summary>
		public double ResponseTime { get; set; }
		/// <summary>
		/// HTTP response status code.
		/// </summary>
		public long ResponseStatus { get; set; }
		/// <summary>
		/// HTTP response status text.
		/// </summary>
		public string ResponseStatusText { get; set; }
		/// <summary>
		/// HTTP response type
		/// </summary>
		public CachedResponseType ResponseType { get; set; }
		/// <summary>
		/// Response headers
		/// </summary>
		public Header[] ResponseHeaders { get; set; }
	}
}
