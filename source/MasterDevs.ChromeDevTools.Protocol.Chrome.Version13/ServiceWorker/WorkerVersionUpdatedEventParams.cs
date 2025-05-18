using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.ServiceWorker
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
