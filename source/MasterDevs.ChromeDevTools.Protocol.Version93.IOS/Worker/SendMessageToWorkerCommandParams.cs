using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Worker
{

	[SupportedBy("IOS")]
	public class SendMessageToWorkerCommandParams: ICommandParams<SendMessageToWorkerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Worker.SendMessageToWorker;
		/// <summary>
		/// WorkerId
		/// </summary>
		public long WorkerId { get; set; }
		/// <summary>
		/// Message
		/// </summary>
		public object Message { get; set; }
	}
}
