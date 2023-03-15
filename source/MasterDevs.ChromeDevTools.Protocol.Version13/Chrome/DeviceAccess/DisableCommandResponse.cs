using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceAccess
{
	/// <summary>
	/// Disable events in this domain.
	/// </summary>
	[CommandResponse(ProtocolName.DeviceAccess.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
