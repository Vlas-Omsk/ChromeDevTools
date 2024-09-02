using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Enables or disables simulating a focused and active page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetFocusEmulationEnabledCommandParams: ICommandParams<SetFocusEmulationEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetFocusEmulationEnabled;
		/// <summary>
		/// Whether to enable to disable focus emulation.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
