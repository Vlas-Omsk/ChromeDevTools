using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.FedCm
{

	[SupportedBy("Chrome")]
	public class SelectAccountCommand: ICommand<SelectAccountCommandResult>
	{
		public string MethodName { get; } = ProtocolName.FedCm.SelectAccount;
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
