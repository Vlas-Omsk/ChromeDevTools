using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	/// <summary>
	/// Returns a single credential stored in the given virtual authenticator that
	/// matches the credential ID.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCredentialCommandParams: ICommandParams<GetCredentialCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.GetCredential;
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
