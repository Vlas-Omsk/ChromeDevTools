using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Clears Idle state overrides.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearIdleOverrideCommandParams: ICommandParams<ClearIdleOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.ClearIdleOverride;
	}
}
