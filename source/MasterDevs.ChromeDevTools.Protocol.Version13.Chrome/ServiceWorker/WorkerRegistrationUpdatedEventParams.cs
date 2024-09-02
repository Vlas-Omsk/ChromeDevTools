using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{
	[EventName(ProtocolName.ServiceWorker.WorkerRegistrationUpdated)]
	[SupportedBy("Chrome")]
	public class WorkerRegistrationUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// Registrations
		/// </summary>
		public ServiceWorkerRegistration[] Registrations { get; set; }
	}
}
