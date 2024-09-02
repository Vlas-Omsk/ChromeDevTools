using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
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
