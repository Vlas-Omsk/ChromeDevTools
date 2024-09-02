using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Sets if stack traces should be captured for Nodes. See `Node.getNodeStackTraces`. Default is disabled.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetNodeStackTracesEnabledCommandResult : ICommandResult
	{
	}
}
