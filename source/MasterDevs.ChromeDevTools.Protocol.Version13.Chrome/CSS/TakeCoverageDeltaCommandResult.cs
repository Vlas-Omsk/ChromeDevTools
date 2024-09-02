using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Obtain list of rules that became used since last call to this method (or since start of coverage
	/// instrumentation).
	/// </summary>

	[SupportedBy("Chrome")]
	public class TakeCoverageDeltaCommandResult : ICommandResult
	{
		/// <summary>
		/// Coverage
		/// </summary>
		public RuleUsage[] Coverage { get; set; }
		/// <summary>
		/// Monotonically increasing time, in seconds.
		/// </summary>
		public double Timestamp { get; set; }
	}
}
