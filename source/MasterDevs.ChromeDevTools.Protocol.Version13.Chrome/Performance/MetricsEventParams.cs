using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Performance
{
	/// <summary>
	/// Current values of the metrics.
	/// </summary>
	[EventName(ProtocolName.Performance.Metrics)]
	[SupportedBy("Chrome")]
	public class MetricsEventParams : IEventParams
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
