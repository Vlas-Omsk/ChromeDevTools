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
	public class AddVirtualAuthenticatorCommandParams: ICommandParams<AddVirtualAuthenticatorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.AddVirtualAuthenticator;
		/// <summary>
		/// Options
		/// </summary>
		public VirtualAuthenticatorOptions Options { get; set; }
	}
}
