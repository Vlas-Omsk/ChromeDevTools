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
	public class SetCPUThrottlingRateCommandResult : ICommandResult
	{
	}
}
