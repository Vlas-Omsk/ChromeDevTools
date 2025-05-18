using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Worker
{

	[SupportedBy("IOS")]
	public class SendMessageToWorkerCommand: ICommand<SendMessageToWorkerCommandResult>
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
