using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Automatically render all web contents using a dark theme.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAutoDarkModeOverrideCommandParams: ICommandParams<SetAutoDarkModeOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetAutoDarkModeOverride;
		/// <summary>
		/// Whether to enable or disable automatic dark mode.
		/// If not specified, any existing override will be cleared.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Enabled { get; set; }
	}
}
