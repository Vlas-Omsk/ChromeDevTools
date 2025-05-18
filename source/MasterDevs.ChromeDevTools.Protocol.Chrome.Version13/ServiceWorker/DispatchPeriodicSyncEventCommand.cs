using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class DispatchPeriodicSyncEventCommand: ICommand<DispatchPeriodicSyncEventCommandResult>
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
