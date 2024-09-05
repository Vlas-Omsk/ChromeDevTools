using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	/// <summary>
	/// Creates and adds a virtual authenticator.
	/// </summary>

	[SupportedBy("Chrome")]
	public class AddVirtualAuthenticatorCommandResult : ICommandResult
	{
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
	}
}