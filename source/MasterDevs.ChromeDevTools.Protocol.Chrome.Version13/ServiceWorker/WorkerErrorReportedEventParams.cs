using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.ServiceWorker
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
