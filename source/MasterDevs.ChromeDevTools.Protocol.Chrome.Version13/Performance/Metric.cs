using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Performance
{
	/// <summary>
	/// Run-time execution metric.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Metric
	{
		/// <summary>
		/// Metric name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Metric value.
		/// </summary>
		public double Value { get; set; }
	}
}
