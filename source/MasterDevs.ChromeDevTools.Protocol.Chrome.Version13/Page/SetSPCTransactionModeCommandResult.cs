using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Sets the Secure Payment Confirmation transaction mode.
	/// https://w3c.github.io/secure-payment-confirmation/#sctn-automation-set-spc-transaction-mode
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSPCTransactionModeCommandResult : ICommandResult
	{
	}
}
