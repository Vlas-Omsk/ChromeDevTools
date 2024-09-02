using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DeviceAccess
{
	/// <summary>
	/// Select a device in response to a DeviceAccess.deviceRequestPrompted event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SelectPromptCommandResult : ICommandResult
	{
	}
}
