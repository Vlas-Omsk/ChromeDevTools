using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.InspectWorker)]
	[SupportedBy("Chrome")]
	public class InspectWorkerCommand: IProtocolCommand<InspectWorkerCommandResponse>
	{
		/// <summary>
		/// VersionId
		/// </summary>
		public string VersionId { get; set; }
	}
}
