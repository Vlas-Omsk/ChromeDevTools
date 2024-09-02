using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Stop tracking rule usage and return the list of rules that were used since last call to
	/// `takeCoverageDelta` (or since start of coverage instrumentation).
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopRuleUsageTrackingCommandParams: ICommandParams<StopRuleUsageTrackingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.StopRuleUsageTracking;
	}
}
