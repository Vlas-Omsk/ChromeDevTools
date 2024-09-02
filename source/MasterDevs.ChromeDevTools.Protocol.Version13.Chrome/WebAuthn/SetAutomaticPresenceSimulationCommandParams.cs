using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	/// <summary>
	/// Sets whether tests of user presence will succeed immediately (if true) or fail to resolve (if false) for an authenticator.
	/// The default is true.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAutomaticPresenceSimulationCommandParams: ICommandParams<SetAutomaticPresenceSimulationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAuthn.SetAutomaticPresenceSimulation;
		/// <summary>
		/// AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
		/// <summary>
		/// Enabled
		/// </summary>
		public bool Enabled { get; set; }
	}
}
