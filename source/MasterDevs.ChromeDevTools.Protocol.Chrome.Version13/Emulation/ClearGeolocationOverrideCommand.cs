using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Clears the overridden Geolocation Position and Error.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearGeolocationOverrideCommand: ICommand<ClearGeolocationOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.ClearGeolocationOverride;
	}
}
