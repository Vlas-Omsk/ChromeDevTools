using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory
{
	/// <summary>
	/// Enable/disable suppressing memory pressure notifications in all processes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetPressureNotificationsSuppressedCommandResult : ICommandResult
	{
	}
}
