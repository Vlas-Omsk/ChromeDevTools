using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Overrides default host system timezone with the specified one.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetTimezoneOverrideCommandResult : ICommandResult
	{
	}
}
