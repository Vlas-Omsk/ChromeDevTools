using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Enables target discovery for the specified locations, when `setDiscoverTargets` was set to
	/// `true`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetRemoteLocationsCommandResult : ICommandResult
	{
	}
}
