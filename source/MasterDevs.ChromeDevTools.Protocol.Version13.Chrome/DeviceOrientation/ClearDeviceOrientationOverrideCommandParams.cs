using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DeviceOrientation
{
	/// <summary>
	/// Clears the overridden Device Orientation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearDeviceOrientationOverrideCommandParams: ICommandParams<ClearDeviceOrientationOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DeviceOrientation.ClearDeviceOrientationOverride;
	}
}
