using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Collect coverage data for the current isolate, and resets execution counters. Precise code
	/// coverage needs to have started.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.TakePreciseCoverage)]
	[SupportedBy("Chrome")]
	public class TakePreciseCoverageCommandResponse
	{
		/// <summary>
		/// Coverage data for the current isolate.
		/// </summary>
		public ScriptCoverage[] Result { get; set; }
		/// <summary>
		/// Monotonically increasing time (in seconds) when the coverage update was taken in the backend.
		/// </summary>
		public double Timestamp { get; set; }
	}
}
