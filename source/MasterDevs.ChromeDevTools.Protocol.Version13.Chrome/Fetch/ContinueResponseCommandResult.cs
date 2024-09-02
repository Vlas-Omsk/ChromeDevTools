using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Fetch
{
	/// <summary>
	/// Continues loading of the paused response, optionally modifying the
	/// response headers. If either responseCode or headers are modified, all of them
	/// must be present.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ContinueResponseCommandResult : ICommandResult
	{
	}
}
