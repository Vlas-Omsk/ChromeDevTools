using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SetDeviceOrientationOverrideCommand: ICommand<SetDeviceOrientationOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetDeviceOrientationOverride;
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
