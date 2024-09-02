using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.FedCm
{

	[SupportedBy("Chrome")]
	public class DismissDialogCommandParams: ICommandParams<DismissDialogCommandResult>
	{
		public string MethodName { get; } = ProtocolName.FedCm.DismissDialog;
		/// <summary>
		/// DialogId
		/// </summary>
		public string DialogId { get; set; }
	}
}
