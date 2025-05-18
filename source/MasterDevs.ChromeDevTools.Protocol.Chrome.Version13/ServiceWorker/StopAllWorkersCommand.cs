using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class StopAllWorkersCommand: ICommand<StopAllWorkersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.StopAllWorkers;
	}
}
