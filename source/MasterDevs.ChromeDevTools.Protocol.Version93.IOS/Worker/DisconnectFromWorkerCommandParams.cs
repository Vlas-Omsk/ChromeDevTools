using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Worker
{

	[SupportedBy("IOS")]
	public class DisconnectFromWorkerCommandParams: ICommandParams<DisconnectFromWorkerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Worker.DisconnectFromWorker;
		/// <summary>
		/// WorkerId
		/// </summary>
		public long WorkerId { get; set; }
	}
}
