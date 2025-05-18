using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Enables touch on platforms which do not support them.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetTouchEmulationEnabledCommand: ICommand<SetTouchEmulationEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetTouchEmulationEnabled;
		/// <summary>
		/// Whether the touch event emulation should be enabled.
		/// </summary>
		public bool Enabled { get; set; }
		/// <summary>
		/// Maximum touch points supported. Defaults to one.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxTouchPoints { get; set; }
	}
}
