using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	/// <summary>
	/// Returns all the credentials stored in the given virtual authenticator.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCredentialsCommandParams: ICommandParams<GetCredentialsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.GetCredentials;
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
	}
}
