using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Triggered when a credential is added to an authenticator.
	/// </summary>
	[EventName(ProtocolName.WebAuthn.CredentialAdded)]
	[SupportedBy("Chrome")]
	public class CredentialAddedEventParams : IEventParams
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
