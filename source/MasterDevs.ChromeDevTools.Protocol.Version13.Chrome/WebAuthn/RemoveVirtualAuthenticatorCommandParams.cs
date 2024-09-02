using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	/// <summary>
	/// Removes the given authenticator.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveVirtualAuthenticatorCommandParams: ICommandParams<RemoveVirtualAuthenticatorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.RemoveVirtualAuthenticator;
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
	}
}
