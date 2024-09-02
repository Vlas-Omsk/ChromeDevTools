using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Allows overriding the automation flag.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAutomationOverrideCommandParams: ICommandParams<SetAutomationOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetAutomationOverride;
		/// <summary>
		/// Whether the override should be enabled.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
