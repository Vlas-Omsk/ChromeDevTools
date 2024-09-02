using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DeviceAccess
{
	/// <summary>
	/// Cancel a prompt in response to a DeviceAccess.deviceRequestPrompted event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CancelPromptCommandResult : ICommandResult
	{
	}
}
