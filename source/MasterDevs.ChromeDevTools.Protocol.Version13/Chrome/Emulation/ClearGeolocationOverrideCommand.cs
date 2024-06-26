using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Clears the overridden Geolocation Position and Error.
	/// </summary>
	[Command(ProtocolName.Emulation.ClearGeolocationOverride)]
	[SupportedBy("Chrome")]
	public class ClearGeolocationOverrideCommand: IProtocolCommand<ClearGeolocationOverrideCommandResponse>
	{
	}
}
