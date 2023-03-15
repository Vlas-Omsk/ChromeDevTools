using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Resets parameters isBogusSignature, isBadUV, isBadUP to false if they are not present.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.SetResponseOverrideBits)]
	[SupportedBy("Chrome")]
	public class SetResponseOverrideBitsCommandResponse
	{
	}
}
