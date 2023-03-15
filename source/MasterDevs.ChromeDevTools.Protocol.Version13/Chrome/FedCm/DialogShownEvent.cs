using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[Event(ProtocolName.FedCm.DialogShown)]
	[SupportedBy("Chrome")]
	public class DialogShownEvent
	{
		/// <summary>
		/// DialogId
		/// </summary>
		public string DialogId { get; set; }
		/// <summary>
		/// Accounts
		/// </summary>
		public Account[] Accounts { get; set; }
	}
}
