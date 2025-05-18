using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Sets whether User Verification succeeds or fails for an authenticator.
	/// The default is true.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetUserVerifiedCommand: ICommand<SetUserVerifiedCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.SetUserVerified;
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
