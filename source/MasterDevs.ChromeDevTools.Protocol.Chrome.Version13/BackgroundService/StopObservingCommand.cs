using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.BackgroundService
{
	/// <summary>
	/// Disables event updates for the service.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopObservingCommand: ICommand<StopObservingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.BackgroundService.StopObserving;
		/// <summary>
		/// Service
		/// </summary>
		public string Service { get; set; }
	}
}
