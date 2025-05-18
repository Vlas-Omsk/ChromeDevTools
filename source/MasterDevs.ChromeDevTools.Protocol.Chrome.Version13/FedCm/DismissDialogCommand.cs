using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.FedCm
{

	[SupportedBy("Chrome")]
	public class DismissDialogCommand: ICommand<DismissDialogCommandResult>
	{
		public string MethodName { get; } = ProtocolName.FedCm.DismissDialog;
		/// <summary>
		/// DialogId
		/// </summary>
		public string DialogId { get; set; }
	}
}
