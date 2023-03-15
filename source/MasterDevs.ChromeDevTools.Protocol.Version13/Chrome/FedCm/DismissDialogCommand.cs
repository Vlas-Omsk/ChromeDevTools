using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[Command(ProtocolName.FedCm.DismissDialog)]
	[SupportedBy("Chrome")]
	public class DismissDialogCommand: IProtocolCommand<DismissDialogCommandResponse>
	{
		/// <summary>
		/// DialogId
		/// </summary>
		public string DialogId { get; set; }
	}
}
