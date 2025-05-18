using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.BackgroundService
{
	/// <summary>
	/// Enables event updates for the service.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartObservingCommand: ICommand<StartObservingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.BackgroundService.StartObserving;
		/// <summary>
		/// Service
		/// </summary>
		public string Service { get; set; }
	}
}
