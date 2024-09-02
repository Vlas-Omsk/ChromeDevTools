using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class InspectWorkerCommandParams: ICommandParams<InspectWorkerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.InspectWorker;
		/// <summary>
		/// VersionId
		/// </summary>
		public string VersionId { get; set; }
	}
}
