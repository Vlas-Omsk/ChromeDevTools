using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class DispatchPeriodicSyncEventCommandParams: ICommandParams<DispatchPeriodicSyncEventCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.DispatchPeriodicSyncEvent;
		/// <summary>
		/// Origin
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// RegistrationId
		/// </summary>
		public string RegistrationId { get; set; }
		/// <summary>
		/// Tag
		/// </summary>
		public string Tag { get; set; }
	}
}
