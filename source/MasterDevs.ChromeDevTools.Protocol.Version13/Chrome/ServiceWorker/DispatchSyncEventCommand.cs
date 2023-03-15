using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.DispatchSyncEvent)]
	[SupportedBy("Chrome")]
	public class DispatchSyncEventCommand: IProtocolCommand<DispatchSyncEventCommandResponse>
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
		/// Tag
		/// </summary>
		public string Tag { get; set; }
		/// <summary>
		/// LastChance
		/// </summary>
		public bool LastChance { get; set; }
	}
}
