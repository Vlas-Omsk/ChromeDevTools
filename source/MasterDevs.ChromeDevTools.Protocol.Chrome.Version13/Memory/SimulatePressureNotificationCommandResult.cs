using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Memory
{
	/// <summary>
	/// Simulate a memory pressure notification in all processes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SimulatePressureNotificationCommandResult : ICommandResult
	{
	}
}
