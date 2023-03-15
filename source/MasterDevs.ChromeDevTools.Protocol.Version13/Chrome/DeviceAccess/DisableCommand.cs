using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceAccess
{
	/// <summary>
	/// Disable events in this domain.
	/// </summary>
	[Command(ProtocolName.DeviceAccess.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: IProtocolCommand<DisableCommandResponse>
	{
	}
}
