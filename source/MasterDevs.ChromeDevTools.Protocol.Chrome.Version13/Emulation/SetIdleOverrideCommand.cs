using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Overrides the Idle state.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetIdleOverrideCommand: ICommand<SetIdleOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetIdleOverride;
		/// <summary>
		/// Mock isUserActive
		/// </summary>
		public bool IsUserActive { get; set; }
		/// <summary>
		/// Mock isScreenUnlocked
		/// </summary>
		public bool IsScreenUnlocked { get; set; }
	}
}
