using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetTouchEmulationEnabledCommand: ICommand<SetTouchEmulationEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetTouchEmulationEnabled;
		/// <summary>
		/// Whether the touch event emulation should be enabled.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
