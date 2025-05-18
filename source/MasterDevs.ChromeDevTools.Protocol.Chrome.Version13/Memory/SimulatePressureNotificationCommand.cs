using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Memory
{
	/// <summary>
	/// Simulate a memory pressure notification in all processes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SimulatePressureNotificationCommand: ICommand<SimulatePressureNotificationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Memory.SimulatePressureNotification;
		/// <summary>
		/// Memory pressure level of the notification.
		/// </summary>
		public string Level { get; set; }
	}
}
