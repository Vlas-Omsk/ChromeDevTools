using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMSnapshot
{
	/// <summary>
	/// Disables DOM snapshot agent for the given page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DisableCommandResult : ICommandResult
	{
	}
}
