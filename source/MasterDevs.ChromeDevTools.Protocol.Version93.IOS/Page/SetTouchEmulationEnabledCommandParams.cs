using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetTouchEmulationEnabledCommandParams: ICommandParams<SetTouchEmulationEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetTouchEmulationEnabled;
		/// <summary>
		/// Whether the touch event emulation should be enabled.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
