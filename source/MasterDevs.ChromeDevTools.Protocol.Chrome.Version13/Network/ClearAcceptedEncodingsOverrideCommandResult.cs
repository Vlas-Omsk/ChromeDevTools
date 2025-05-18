using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Clears accepted encodings set by setAcceptedEncodings
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearAcceptedEncodingsOverrideCommandResult : ICommandResult
	{
	}
}
