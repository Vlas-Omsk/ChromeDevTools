using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[CommandResponse(ProtocolName.FedCm.DismissDialog)]
	[SupportedBy("Chrome")]
	public class DismissDialogCommandResponse
	{
	}
}
