using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Chrome histogram.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Histogram
	{
		/// <summary>
		/// Name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Sum of sample values.
		/// </summary>
		public long Sum { get; set; }
		/// <summary>
		/// Total number of samples.
		/// </summary>
		public long Count { get; set; }
		/// <summary>
		/// Buckets.
		/// </summary>
		public Bucket[] Buckets { get; set; }
	}
}
