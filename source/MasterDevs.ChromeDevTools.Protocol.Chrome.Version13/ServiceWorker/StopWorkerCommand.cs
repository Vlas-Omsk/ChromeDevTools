using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class StopWorkerCommand: ICommand<StopWorkerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.StopWorker;
		/// <summary>
		/// VersionId
		/// </summary>
		public string VersionId { get; set; }
	}
}
