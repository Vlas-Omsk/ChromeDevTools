using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[Command(ProtocolName.FedCm.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: IProtocolCommand<EnableCommandResponse>
	{
	}
}
