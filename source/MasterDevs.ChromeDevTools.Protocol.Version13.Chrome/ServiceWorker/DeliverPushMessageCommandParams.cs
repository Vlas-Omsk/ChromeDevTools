using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class DeliverPushMessageCommandParams: ICommandParams<DeliverPushMessageCommandResult>
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
