using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Clears the overridden Geolocation Position and Error.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearGeolocationOverrideCommandParams: ICommandParams<ClearGeolocationOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.ClearGeolocationOverride;
	}
}
