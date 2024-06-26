using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Clears accepted encodings set by setAcceptedEncodings
	/// </summary>
	[Command(ProtocolName.Network.ClearAcceptedEncodingsOverride)]
	[SupportedBy("Chrome")]
	public class ClearAcceptedEncodingsOverrideCommand: IProtocolCommand<ClearAcceptedEncodingsOverrideCommandResponse>
	{
	}
}
