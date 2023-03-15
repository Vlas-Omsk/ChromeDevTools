using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceAccess
{
	/// <summary>
	/// Enable events in this domain.
	/// </summary>
	[CommandResponse(ProtocolName.DeviceAccess.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
