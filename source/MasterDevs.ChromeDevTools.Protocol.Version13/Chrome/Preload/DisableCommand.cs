using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	[Command(ProtocolName.Preload.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: IProtocolCommand<DisableCommandResponse>
	{
	}
}
