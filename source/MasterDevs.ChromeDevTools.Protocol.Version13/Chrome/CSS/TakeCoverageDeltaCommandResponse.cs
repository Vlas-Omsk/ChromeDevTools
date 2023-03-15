using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Obtain list of rules that became used since last call to this method (or since start of coverage
	/// instrumentation).
	/// </summary>
	[CommandResponse(ProtocolName.CSS.TakeCoverageDelta)]
	[SupportedBy("Chrome")]
	public class TakeCoverageDeltaCommandResponse
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
