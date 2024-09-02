using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Sets the Secure Payment Confirmation transaction mode.
	/// https://w3c.github.io/secure-payment-confirmation/#sctn-automation-set-spc-transaction-mode
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSPCTransactionModeCommandParams: ICommandParams<SetSPCTransactionModeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetSPCTransactionMode;
		/// <summary>
		/// Mode
		/// </summary>
		public string Mode { get; set; }
	}
}
