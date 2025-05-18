using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.FedCm
{

	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.FedCm.Disable;
	}
}
