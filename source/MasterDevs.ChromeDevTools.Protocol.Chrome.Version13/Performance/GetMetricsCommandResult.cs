using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Performance
{
	/// <summary>
	/// Retrieve current values of run-time metrics.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetMetricsCommandResult : ICommandResult
	{
		/// <summary>
		/// Current values for run-time metrics.
		/// </summary>
		public Metric[] Metrics { get; set; }
	}
}
