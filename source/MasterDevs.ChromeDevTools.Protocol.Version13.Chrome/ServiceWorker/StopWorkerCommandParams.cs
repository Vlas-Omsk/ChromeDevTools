using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class StopWorkerCommandParams: ICommandParams<StopWorkerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.StopWorker;
		/// <summary>
		/// VersionId
		/// </summary>
		public string VersionId { get; set; }
	}
}
