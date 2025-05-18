using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAuthn
{
	/// <summary>
	/// Resets parameters isBogusSignature, isBadUV, isBadUP to false if they are not present.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetResponseOverrideBitsCommandResult : ICommandResult
	{
	}
}
