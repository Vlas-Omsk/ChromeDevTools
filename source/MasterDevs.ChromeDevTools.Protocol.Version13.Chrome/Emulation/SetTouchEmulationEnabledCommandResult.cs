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
	public class SetTouchEmulationEnabledCommandResult : ICommandResult
	{
	}
}
