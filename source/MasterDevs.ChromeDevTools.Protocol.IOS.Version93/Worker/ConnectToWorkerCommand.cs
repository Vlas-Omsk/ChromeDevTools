using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Worker
{

	[SupportedBy("IOS")]
	public class ConnectToWorkerCommand: ICommand<ConnectToWorkerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Worker.ConnectToWorker;
		/// <summary>
		/// WorkerId
		/// </summary>
		public long WorkerId { get; set; }
	}
}
