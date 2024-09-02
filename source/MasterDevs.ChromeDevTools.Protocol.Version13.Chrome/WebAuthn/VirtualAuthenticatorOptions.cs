using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	[SupportedBy("Chrome")]
	public class VirtualAuthenticatorOptions
	{
		/// <summary>
		/// Protocol
		/// </summary>
		public AuthenticatorProtocol Protocol { get; set; }
		/// <summary>
		/// Defaults to ctap2_0. Ignored if |protocol| == u2f.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Ctap2Version Ctap2Version { get; set; }
		/// <summary>
		/// Transport
		/// </summary>
		public AuthenticatorTransport Transport { get; set; }
		/// <summary>
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasResidentKey { get; set; }
		/// <summary>
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasUserVerification { get; set; }
		/// <summary>
		/// If set to true, the authenticator will support the largeBlob extension.
		/// https://w3c.github.io/webauthn#largeBlob
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasLargeBlob { get; set; }
		/// <summary>
		/// If set to true, the authenticator will support the credBlob extension.
		/// https://fidoalliance.org/specs/fido-v2.1-rd-20201208/fido-client-to-authenticator-protocol-v2.1-rd-20201208.html#sctn-credBlob-extension
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasCredBlob { get; set; }
		/// <summary>
		/// If set to true, the authenticator will support the minPinLength extension.
		/// https://fidoalliance.org/specs/fido-v2.1-ps-20210615/fido-client-to-authenticator-protocol-v2.1-ps-20210615.html#sctn-minpinlength-extension
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasMinPinLength { get; set; }
		/// <summary>
		/// If set to true, the authenticator will support the prf extension.
		/// https://w3c.github.io/webauthn/#prf-extension
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasPrf { get; set; }
		/// <summary>
		/// If set to true, tests of user presence will succeed immediately.
		/// Otherwise, they will not be resolved. Defaults to true.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AutomaticPresenceSimulation { get; set; }
		/// <summary>
		/// Sets whether User Verification succeeds or fails for an authenticator.
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsUserVerified { get; set; }
	}
}
