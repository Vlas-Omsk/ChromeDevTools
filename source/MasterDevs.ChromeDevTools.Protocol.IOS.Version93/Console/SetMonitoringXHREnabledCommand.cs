using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Console
{
	/// <summary>
	/// Toggles monitoring of XMLHttpRequest. If <code>true</code>, console will receive messages upon each XHR issued.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetMonitoringXHREnabledCommand: ICommand<SetMonitoringXHREnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Console.SetMonitoringXHREnabled;
		/// <summary>
		/// Monitoring enabled state.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
