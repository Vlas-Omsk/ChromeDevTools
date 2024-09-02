using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.IndexedDB
{
	/// <summary>
	/// Key range.
	/// </summary>
	[SupportedBy("IOS")]
	public class KeyRange
	{
		/// <summary>
		/// Lower bound.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Key Lower { get; set; }
		/// <summary>
		/// Upper bound.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Key Upper { get; set; }
		/// <summary>
		/// If true lower bound is open.
		/// </summary>
		public bool LowerOpen { get; set; }
		/// <summary>
		/// If true upper bound is open.
		/// </summary>
		public bool UpperOpen { get; set; }
	}
}
