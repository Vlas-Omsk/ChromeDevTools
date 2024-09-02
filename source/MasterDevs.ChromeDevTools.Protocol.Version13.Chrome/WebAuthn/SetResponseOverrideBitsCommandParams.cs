using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	/// <summary>
	/// Resets parameters isBogusSignature, isBadUV, isBadUP to false if they are not present.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetResponseOverrideBitsCommandParams: ICommandParams<SetResponseOverrideBitsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.SetResponseOverrideBits;
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// If isBogusSignature is set, overrides the signature in the authenticator response to be zero.
		/// Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsBogusSignature { get; set; }
		/// <summary>
		/// If isBadUV is set, overrides the UV bit in the flags in the authenticator response to
		/// be zero. Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsBadUV { get; set; }
		/// <summary>
		/// If isBadUP is set, overrides the UP bit in the flags in the authenticator response to
		/// be zero. Defaults to false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsBadUP { get; set; }
	}
}
