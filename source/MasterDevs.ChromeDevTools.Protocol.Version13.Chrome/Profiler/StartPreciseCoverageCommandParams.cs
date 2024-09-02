using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Profiler
{
	/// <summary>
	/// Enable precise code coverage. Coverage data for JavaScript executed before enabling precise code
	/// coverage may be incomplete. Enabling prevents running optimized code and resets execution
	/// counters.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartPreciseCoverageCommandParams: ICommandParams<StartPreciseCoverageCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Profiler.StartPreciseCoverage;
		/// <summary>
		/// Collect accurate call counts beyond simple 'covered' or 'not covered'.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? CallCount { get; set; }
		/// <summary>
		/// Collect block-based coverage.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Detailed { get; set; }
		/// <summary>
		/// Allow the backend to send updates on its own initiative
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AllowTriggeredUpdates { get; set; }
	}
}
