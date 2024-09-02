using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	/// <summary>
	/// Resets parameters isBogusSignature, isBadUV, isBadUP to false if they are not present.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetResponseOverrideBitsCommandResult : ICommandResult
	{
	}
}
