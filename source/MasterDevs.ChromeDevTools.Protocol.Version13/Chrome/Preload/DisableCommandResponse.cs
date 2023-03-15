using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	[CommandResponse(ProtocolName.Preload.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
