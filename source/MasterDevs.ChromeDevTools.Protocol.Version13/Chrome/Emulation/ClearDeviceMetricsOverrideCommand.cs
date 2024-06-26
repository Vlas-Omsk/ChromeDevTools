using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Clears the overridden device metrics.
	/// </summary>
	[Command(ProtocolName.Emulation.ClearDeviceMetricsOverride)]
	[SupportedBy("Chrome")]
	public class ClearDeviceMetricsOverrideCommand: IProtocolCommand<ClearDeviceMetricsOverrideCommandResponse>
	{
	}
}
