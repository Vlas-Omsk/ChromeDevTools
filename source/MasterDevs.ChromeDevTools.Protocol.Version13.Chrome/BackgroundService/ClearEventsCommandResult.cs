using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.BackgroundService
{
	/// <summary>
	/// Clears all stored data for the service.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearEventsCommandResult : ICommandResult
	{
	}
}
