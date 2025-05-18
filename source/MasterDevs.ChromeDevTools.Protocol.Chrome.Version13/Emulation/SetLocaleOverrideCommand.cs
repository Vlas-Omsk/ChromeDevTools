using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Overrides default host system locale with the specified one.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetLocaleOverrideCommand: ICommand<SetLocaleOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetLocaleOverride;
		/// <summary>
		/// ICU style C locale (e.g. "en_US"). If not specified or empty, disables the override and
		/// restores default host system locale.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Locale { get; set; }
	}
}
