using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.DeliverPushMessage)]
	[SupportedBy("Chrome")]
	public class DeliverPushMessageCommand: ICommandParams<DeliverPushMessageCommandResponse>
	{
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
