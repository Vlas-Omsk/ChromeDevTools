using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Removes the given authenticator.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveVirtualAuthenticatorCommand: ICommand<RemoveVirtualAuthenticatorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.RemoveVirtualAuthenticator;
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
	}
}
