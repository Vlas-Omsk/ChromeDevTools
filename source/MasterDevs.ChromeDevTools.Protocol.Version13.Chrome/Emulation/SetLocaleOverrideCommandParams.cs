using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Overrides default host system locale with the specified one.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetLocaleOverrideCommandParams: ICommandParams<SetLocaleOverrideCommandResult>
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
