using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Returns a single credential stored in the given virtual authenticator that
	/// matches the credential ID.
	/// </summary>
	[Command(ProtocolName.WebAuthn.GetCredential)]
	[SupportedBy("Chrome")]
	public class GetCredentialCommand: ICommandParams<GetCredentialCommandResponse>
	{
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// CredentialId
		/// </summary>
		public string CredentialId { get; set; }
	}
}
