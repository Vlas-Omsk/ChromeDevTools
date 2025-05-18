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
	public class SetTouchEmulationEnabledCommandResult : ICommandResult
	{
	}
}
