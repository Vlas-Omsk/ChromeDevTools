using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Overrides default host system timezone with the specified one.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetTimezoneOverrideCommand: ICommand<SetTimezoneOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetTimezoneOverride;
		/// <summary>
		/// The timezone identifier. If empty, disables the override and
		/// restores default host system timezone.
		/// </summary>
		public string TimezoneId { get; set; }
	}
}
