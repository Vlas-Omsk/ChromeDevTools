using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
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
