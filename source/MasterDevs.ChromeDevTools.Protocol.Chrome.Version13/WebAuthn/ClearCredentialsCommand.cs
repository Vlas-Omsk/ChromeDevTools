using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Clears all the credentials from the specified device.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearCredentialsCommand: ICommand<ClearCredentialsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.ClearCredentials;
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
	}
}
