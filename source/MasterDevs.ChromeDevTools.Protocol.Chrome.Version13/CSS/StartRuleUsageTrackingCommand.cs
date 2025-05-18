using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Enables the selector recording.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartRuleUsageTrackingCommand: ICommand<StartRuleUsageTrackingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.StartRuleUsageTracking;
	}
}
