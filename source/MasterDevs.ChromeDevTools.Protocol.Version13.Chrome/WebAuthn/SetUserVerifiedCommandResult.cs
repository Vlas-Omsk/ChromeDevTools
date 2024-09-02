using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	/// <summary>
	/// Sets whether User Verification succeeds or fails for an authenticator.
	/// The default is true.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetUserVerifiedCommandResult : ICommandResult
	{
	}
}
