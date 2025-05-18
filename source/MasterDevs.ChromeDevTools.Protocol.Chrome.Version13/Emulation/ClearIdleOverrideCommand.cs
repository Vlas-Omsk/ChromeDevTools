using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Clears Idle state overrides.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearIdleOverrideCommand: ICommand<ClearIdleOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.ClearIdleOverride;
	}
}
