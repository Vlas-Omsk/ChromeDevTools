using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Input
{
	/// <summary>
	/// Ignores input events (useful while auditing page).
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetIgnoreInputEventsCommandResult : ICommandResult
	{
	}
}
