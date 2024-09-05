using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.FedCm
{

	[SupportedBy("Chrome")]
	public class EnableCommandParams: ICommandParams<EnableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.FedCm.Enable;
	}
}