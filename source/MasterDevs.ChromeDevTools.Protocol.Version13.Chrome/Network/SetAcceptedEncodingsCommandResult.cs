using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Sets a list of content encodings that will be accepted. Empty list means no encoding is accepted.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAcceptedEncodingsCommandResult : ICommandResult
	{
	}
}
