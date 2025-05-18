using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.IndexedDB
{
	/// <summary>
	/// Key path.
	/// </summary>
	[SupportedBy("Chrome")]
	public class KeyPath
	{
		/// <summary>
		/// Key path type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// String value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string String { get; set; }
		/// <summary>
		/// Array value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Array { get; set; }
	}
}
