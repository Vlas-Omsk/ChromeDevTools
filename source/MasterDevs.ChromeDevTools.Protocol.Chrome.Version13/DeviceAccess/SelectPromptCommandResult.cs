using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DeviceAccess
{
	/// <summary>
	/// Select a device in response to a DeviceAccess.deviceRequestPrompted event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SelectPromptCommandResult : ICommandResult
	{
	}
}
