using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Clears all the credentials from the specified device.
	/// </summary>
	[Command(ProtocolName.WebAuthn.ClearCredentials)]
	[SupportedBy("Chrome")]
	public class ClearCredentialsCommand: IProtocolCommand<ClearCredentialsCommandResponse>
	{
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
	}
}
