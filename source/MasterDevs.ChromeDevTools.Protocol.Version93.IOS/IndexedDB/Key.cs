using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.IndexedDB
{
	/// <summary>
	/// Key.
	/// </summary>
	[SupportedBy("IOS")]
	public class Key
	{
		/// <summary>
		/// Key type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Number value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Number { get; set; }
		/// <summary>
		/// String value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string String { get; set; }
		/// <summary>
		/// Date value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Date { get; set; }
		/// <summary>
		/// Array value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Key[] Array { get; set; }
	}
}
