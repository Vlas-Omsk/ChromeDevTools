using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Overrides the values of device screen dimensions (window.screen.width, window.screen.height,
	/// window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media
	/// query results).
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetDeviceMetricsOverrideCommandResult : ICommandResult
	{
	}
}
