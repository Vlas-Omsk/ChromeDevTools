using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	[CommandResponse(ProtocolName.Preload.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
