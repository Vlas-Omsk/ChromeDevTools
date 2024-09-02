using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Clears accepted encodings set by setAcceptedEncodings
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearAcceptedEncodingsOverrideCommandParams: ICommandParams<ClearAcceptedEncodingsOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.ClearAcceptedEncodingsOverride;
	}
}
