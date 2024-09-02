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
	public class StartPreciseCoverageCommandResult : ICommandResult
	{
		/// <summary>
		/// Monotonically increasing time (in seconds) when the coverage update was taken in the backend.
		/// </summary>
		public double Timestamp { get; set; }
	}
}
