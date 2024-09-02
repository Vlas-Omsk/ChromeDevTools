using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Worker
{

	[SupportedBy("IOS")]
	public class SetAutoconnectToWorkersCommandParams: ICommandParams<SetAutoconnectToWorkersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Worker.SetAutoconnectToWorkers;
		/// <summary>
		/// Value
		/// </summary>
		public bool Value { get; set; }
	}
}
