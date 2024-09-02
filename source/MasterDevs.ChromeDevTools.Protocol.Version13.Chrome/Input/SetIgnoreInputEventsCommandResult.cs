using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Input
{
	/// <summary>
	/// Ignores input events (useful while auditing page).
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetIgnoreInputEventsCommandResult : ICommandResult
	{
	}
}
