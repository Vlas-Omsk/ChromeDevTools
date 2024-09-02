using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Performance
{
	/// <summary>
	/// Retrieve current values of run-time metrics.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetMetricsCommandParams: ICommandParams<GetMetricsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Performance.GetMetrics;
	}
}
