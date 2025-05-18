using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Worker
{

	[SupportedBy("IOS")]
	public class SetAutoconnectToWorkersCommand: ICommand<SetAutoconnectToWorkersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Worker.SetAutoconnectToWorkers;
		/// <summary>
		/// Value
		/// </summary>
		public bool Value { get; set; }
	}
}
