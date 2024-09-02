using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{
	[EventName(ProtocolName.ServiceWorker.WorkerVersionUpdated)]
	[SupportedBy("Chrome")]
	public class WorkerVersionUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// Versions
		/// </summary>
		public ServiceWorkerVersion[] Versions { get; set; }
	}
}
