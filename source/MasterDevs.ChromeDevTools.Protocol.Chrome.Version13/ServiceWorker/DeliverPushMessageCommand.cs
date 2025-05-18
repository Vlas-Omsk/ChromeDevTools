using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class DeliverPushMessageCommand: ICommand<DeliverPushMessageCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.DeliverPushMessage;
		/// <summary>
		/// Origin
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// RegistrationId
		/// </summary>
		public string RegistrationId { get; set; }
		/// <summary>
		/// Data
		/// </summary>
		public string Data { get; set; }
	}
}
