using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Returns all the credentials stored in the given virtual authenticator.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCredentialsCommand: ICommand<GetCredentialsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.GetCredentials;
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
	}
}
