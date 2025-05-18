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
	public class SetTimezoneOverrideCommandResult : ICommandResult
	{
	}
}
