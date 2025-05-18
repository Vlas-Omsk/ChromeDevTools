using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DeviceOrientation
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetDeviceOrientationOverrideCommand: ICommand<SetDeviceOrientationOverrideCommandResult>
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
