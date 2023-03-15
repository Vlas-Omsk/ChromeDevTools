using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.StopWorker)]
	[SupportedBy("Chrome")]
	public class StopWorkerCommand: IProtocolCommand<StopWorkerCommandResponse>
	{
		/// <summary>
		/// VersionId
		/// </summary>
		public string VersionId { get; set; }
	}
}
