using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.FedCm
{
	[EventName(ProtocolName.FedCm.DialogShown)]
	[SupportedBy("Chrome")]
	public class DialogShownEventParams : IEventParams
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
