using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Worker
{

	[SupportedBy("IOS")]
	public class ConnectToWorkerCommandParams: ICommandParams<ConnectToWorkerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Worker.ConnectToWorker;
		/// <summary>
		/// WorkerId
		/// </summary>
		public long WorkerId { get; set; }
	}
}
