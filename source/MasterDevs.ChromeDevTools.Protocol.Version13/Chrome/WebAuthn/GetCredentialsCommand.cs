using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Returns all the credentials stored in the given virtual authenticator.
	/// </summary>
	[Command(ProtocolName.WebAuthn.GetCredentials)]
	[SupportedBy("Chrome")]
	public class GetCredentialsCommand: IProtocolCommand<GetCredentialsCommandResponse>
	{
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
	}
}
