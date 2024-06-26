using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommand: IProtocolCommand<DisableCommandResponse>
	{
	}
}
