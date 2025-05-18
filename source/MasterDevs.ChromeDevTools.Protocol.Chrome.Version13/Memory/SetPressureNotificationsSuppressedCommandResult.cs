using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Memory
{
	/// <summary>
	/// Enable/disable suppressing memory pressure notifications in all processes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetPressureNotificationsSuppressedCommandResult : ICommandResult
	{
	}
}
