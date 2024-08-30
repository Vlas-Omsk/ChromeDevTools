using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.SetAutoconnectToWorkers)]
	[SupportedBy("iOS")]
	public class SetAutoconnectToWorkersCommand: ICommandParams<SetAutoconnectToWorkersCommandResponse>
	{
		/// <summary>
		/// Value
		/// </summary>
		public bool Value { get; set; }
	}
}
