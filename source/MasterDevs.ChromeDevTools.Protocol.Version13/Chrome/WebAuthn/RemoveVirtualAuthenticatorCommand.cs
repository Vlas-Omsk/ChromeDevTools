using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Removes the given authenticator.
	/// </summary>
	[Command(ProtocolName.WebAuthn.RemoveVirtualAuthenticator)]
	[SupportedBy("Chrome")]
	public class RemoveVirtualAuthenticatorCommand: IProtocolCommand<RemoveVirtualAuthenticatorCommandResponse>
	{
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
	}
}
