using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Removes a credential from the authenticator.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveCredentialCommand: ICommand<RemoveCredentialCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.RemoveCredential;
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
