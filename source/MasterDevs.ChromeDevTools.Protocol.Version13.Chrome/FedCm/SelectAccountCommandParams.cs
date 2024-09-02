using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.FedCm
{

	[SupportedBy("Chrome")]
	public class SelectAccountCommandParams: ICommandParams<SelectAccountCommandResult>
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
