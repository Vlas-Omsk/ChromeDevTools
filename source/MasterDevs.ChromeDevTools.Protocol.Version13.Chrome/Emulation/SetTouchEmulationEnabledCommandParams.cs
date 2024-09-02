using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Enables touch on platforms which do not support them.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetTouchEmulationEnabledCommandParams: ICommandParams<SetTouchEmulationEnabledCommandResult>
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
