using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Returns a single credential stored in the given virtual authenticator that
	/// matches the credential ID.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCredentialCommandResult : ICommandResult
	{
		/// <summary>
		/// Credential
		/// </summary>
		public Credential Credential { get; set; }
	}
}
