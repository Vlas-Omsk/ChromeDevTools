using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[Command(ProtocolName.FedCm.SelectAccount)]
	[SupportedBy("Chrome")]
	public class SelectAccountCommand: ICommandParams<SelectAccountCommandResponse>
	{
		/// <summary>
		/// DialogId
		/// </summary>
		public string DialogId { get; set; }
		/// <summary>
		/// AccountIndex
		/// </summary>
		public long AccountIndex { get; set; }
	}
}
