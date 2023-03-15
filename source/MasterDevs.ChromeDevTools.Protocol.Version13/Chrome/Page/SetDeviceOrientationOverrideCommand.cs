using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Page.SetDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class SetDeviceOrientationOverrideCommand: IProtocolCommand<SetDeviceOrientationOverrideCommandResponse>
	{
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
