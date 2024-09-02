using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory
{
	/// <summary>
	/// Simulate a memory pressure notification in all processes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SimulatePressureNotificationCommandParams: ICommandParams<SimulatePressureNotificationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Memory.SimulatePressureNotification;
		/// <summary>
		/// Memory pressure level of the notification.
		/// </summary>
		public string Level { get; set; }
	}
}
