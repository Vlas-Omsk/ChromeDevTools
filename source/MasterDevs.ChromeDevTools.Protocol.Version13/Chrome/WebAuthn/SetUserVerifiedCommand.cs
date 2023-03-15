using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Sets whether User Verification succeeds or fails for an authenticator.
	/// The default is true.
	/// </summary>
	[Command(ProtocolName.WebAuthn.SetUserVerified)]
	[SupportedBy("Chrome")]
	public class SetUserVerifiedCommand: IProtocolCommand<SetUserVerifiedCommandResponse>
	{
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// IsUserVerified
		/// </summary>
		public bool IsUserVerified { get; set; }
	}
}
