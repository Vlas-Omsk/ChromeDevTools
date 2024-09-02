using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class StopAllWorkersCommandParams: ICommandParams<StopAllWorkersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.StopAllWorkers;
	}
}
