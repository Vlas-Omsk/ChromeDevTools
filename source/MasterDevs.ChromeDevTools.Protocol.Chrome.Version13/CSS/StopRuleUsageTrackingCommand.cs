using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Stop tracking rule usage and return the list of rules that were used since last call to
	/// `takeCoverageDelta` (or since start of coverage instrumentation).
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopRuleUsageTrackingCommand: ICommand<StopRuleUsageTrackingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.StopRuleUsageTracking;
	}
}
