using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Sets whether tests of user presence will succeed immediately (if true) or fail to resolve (if false) for an authenticator.
	/// The default is true.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAutomaticPresenceSimulationCommandResult : ICommandResult
	{
	}
}
