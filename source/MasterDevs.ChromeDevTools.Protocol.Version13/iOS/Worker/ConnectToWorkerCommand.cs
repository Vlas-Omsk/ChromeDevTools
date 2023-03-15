using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.ConnectToWorker)]
	[SupportedBy("iOS")]
	public class ConnectToWorkerCommand: IProtocolCommand<ConnectToWorkerCommandResponse>
	{
		/// <summary>
		/// WorkerId
		/// </summary>
		public long WorkerId { get; set; }
	}
}
