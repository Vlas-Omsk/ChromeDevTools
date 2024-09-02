using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Chrome histogram bucket.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Bucket
	{
		/// <summary>
		/// Minimum value (inclusive).
		/// </summary>
		public long Low { get; set; }
		/// <summary>
		/// Maximum value (exclusive).
		/// </summary>
		public long High { get; set; }
		/// <summary>
		/// Number of samples.
		/// </summary>
		public long Count { get; set; }
	}
}
