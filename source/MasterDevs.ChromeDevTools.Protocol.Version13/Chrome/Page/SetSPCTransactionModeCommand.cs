using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Sets the Secure Payment Confirmation transaction mode.
	/// https://w3c.github.io/secure-payment-confirmation/#sctn-automation-set-spc-transaction-mode
	/// </summary>
	[Command(ProtocolName.Page.SetSPCTransactionMode)]
	[SupportedBy("Chrome")]
	public class SetSPCTransactionModeCommand: ICommandParams<SetSPCTransactionModeCommandResponse>
	{
		/// <summary>
		/// Mode
		/// </summary>
		public string Mode { get; set; }
	}
}
