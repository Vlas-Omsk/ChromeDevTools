using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Overrides the Idle state.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetIdleOverrideCommandParams: ICommandParams<SetIdleOverrideCommandResult>
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
