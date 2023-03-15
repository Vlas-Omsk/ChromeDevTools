using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Triggered when a credential is used in a webauthn assertion.
	/// </summary>
	[Event(ProtocolName.WebAuthn.CredentialAsserted)]
	[SupportedBy("Chrome")]
	public class CredentialAssertedEvent
	{
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
