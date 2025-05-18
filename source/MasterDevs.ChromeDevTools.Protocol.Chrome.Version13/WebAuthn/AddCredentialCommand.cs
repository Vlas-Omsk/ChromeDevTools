using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Adds the credential to the specified authenticator.
	/// </summary>

	[SupportedBy("Chrome")]
	public class AddCredentialCommand: ICommand<AddCredentialCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.AddCredential;
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// Credential
		/// </summary>
		public Credential Credential { get; set; }
	}
}
