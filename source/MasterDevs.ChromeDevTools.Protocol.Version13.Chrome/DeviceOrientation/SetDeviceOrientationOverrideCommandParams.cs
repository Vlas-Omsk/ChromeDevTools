using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DeviceOrientation
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetDeviceOrientationOverrideCommandParams: ICommandParams<SetDeviceOrientationOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DeviceOrientation.SetDeviceOrientationOverride;
		/// <summary>
		/// Mock alpha
		/// </summary>
		public double Alpha { get; set; }
		/// <summary>
		/// Mock beta
		/// </summary>
		public double Beta { get; set; }
		/// <summary>
		/// Mock gamma
		/// </summary>
		public double Gamma { get; set; }
	}
}
