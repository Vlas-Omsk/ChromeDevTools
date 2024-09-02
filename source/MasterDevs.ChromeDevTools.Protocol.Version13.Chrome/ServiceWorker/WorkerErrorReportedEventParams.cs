using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{
	[EventName(ProtocolName.ServiceWorker.WorkerErrorReported)]
	[SupportedBy("Chrome")]
	public class WorkerErrorReportedEventParams : IEventParams
	{
		/// <summary>
		/// ErrorMessage
		/// </summary>
		public ServiceWorkerErrorMessage ErrorMessage { get; set; }
	}
}
