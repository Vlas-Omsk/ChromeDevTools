using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Performance
{
	/// <summary>
	/// Current values of the metrics.
	/// </summary>
	[Event(ProtocolName.Performance.Metrics)]
	[SupportedBy("Chrome")]
	public class MetricsEvent
	{
		/// <summary>
		/// Current values of the metrics.
		/// </summary>
		public Metric[] Metrics { get; set; }
		/// <summary>
		/// Timestamp title.
		/// </summary>
		public string Title { get; set; }
	}
}
