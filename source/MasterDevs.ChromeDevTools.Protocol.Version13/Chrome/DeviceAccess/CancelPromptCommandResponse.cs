using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceAccess
{
	/// <summary>
	/// Cancel a prompt in response to a DeviceAccess.deviceRequestPrompted event.
	/// </summary>
	[CommandResponse(ProtocolName.DeviceAccess.CancelPrompt)]
	[SupportedBy("Chrome")]
	public class CancelPromptCommandResponse
	{
	}
}
