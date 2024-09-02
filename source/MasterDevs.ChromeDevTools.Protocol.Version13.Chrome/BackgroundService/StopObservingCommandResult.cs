using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.BackgroundService
{
	/// <summary>
	/// Disables event updates for the service.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopObservingCommandResult : ICommandResult
	{
	}
}
