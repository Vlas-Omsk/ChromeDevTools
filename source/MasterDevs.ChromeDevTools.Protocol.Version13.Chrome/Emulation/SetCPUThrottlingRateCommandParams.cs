using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Enables CPU throttling to emulate slow CPUs.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetCPUThrottlingRateCommandParams: ICommandParams<SetCPUThrottlingRateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetCPUThrottlingRate;
		/// <summary>
		/// Throttling rate as a slowdown factor (1 is no throttle, 2 is 2x slowdown, etc).
		/// </summary>
		public double Rate { get; set; }
	}
}
