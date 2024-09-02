using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	/// <summary>
	/// Clears all the credentials from the specified device.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearCredentialsCommandParams: ICommandParams<ClearCredentialsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.ClearCredentials;
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
	}
}
