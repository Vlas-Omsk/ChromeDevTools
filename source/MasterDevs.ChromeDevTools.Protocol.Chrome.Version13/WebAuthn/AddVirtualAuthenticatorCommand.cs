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
	public class AddVirtualAuthenticatorCommand: ICommand<AddVirtualAuthenticatorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.AddVirtualAuthenticator;
		/// <summary>
		/// Options
		/// </summary>
		public VirtualAuthenticatorOptions Options { get; set; }
	}
}
