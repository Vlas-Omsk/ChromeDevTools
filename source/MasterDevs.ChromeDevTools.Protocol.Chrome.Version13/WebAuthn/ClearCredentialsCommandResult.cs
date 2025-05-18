using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Clears all the credentials from the specified device.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearCredentialsCommandResult : ICommandResult
	{
	}
}
