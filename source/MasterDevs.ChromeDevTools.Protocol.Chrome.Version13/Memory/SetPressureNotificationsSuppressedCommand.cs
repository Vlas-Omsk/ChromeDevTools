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
	public class SetPressureNotificationsSuppressedCommand: ICommand<SetPressureNotificationsSuppressedCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Memory.SetPressureNotificationsSuppressed;
		/// <summary>
		/// If true, memory pressure notifications will be suppressed.
		/// </summary>
		public bool Suppressed { get; set; }
	}
}
