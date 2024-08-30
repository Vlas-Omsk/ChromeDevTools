using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>
	[Command(ProtocolName.Page.SetTouchEmulationEnabled)]
	[SupportedBy("iOS")]
	public class SetTouchEmulationEnabledCommand: ICommandParams<SetTouchEmulationEnabledCommandResponse>
	{
		/// <summary>
		/// Whether the touch event emulation should be enabled.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
