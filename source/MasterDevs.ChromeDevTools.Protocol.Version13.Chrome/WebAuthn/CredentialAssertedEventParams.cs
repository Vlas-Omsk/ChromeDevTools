using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	/// <summary>
	/// Triggered when a credential is used in a webauthn assertion.
	/// </summary>
	[EventName(ProtocolName.WebAuthn.CredentialAsserted)]
	[SupportedBy("Chrome")]
	public class CredentialAssertedEventParams : IEventParams
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
