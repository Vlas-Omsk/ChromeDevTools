using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.IndexedDB
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
