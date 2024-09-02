using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position
	/// unavailable.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetGeolocationOverrideCommandResult : ICommandResult
	{
	}
}
