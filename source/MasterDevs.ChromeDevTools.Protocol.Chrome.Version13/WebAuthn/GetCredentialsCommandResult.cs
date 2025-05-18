using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Returns all the credentials stored in the given virtual authenticator.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCredentialsCommandResult : ICommandResult
	{
		/// <summary>
		/// Credentials
		/// </summary>
		public Credential[] Credentials { get; set; }
	}
}
