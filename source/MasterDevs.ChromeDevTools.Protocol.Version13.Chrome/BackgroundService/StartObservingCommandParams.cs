using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.BackgroundService
{
	/// <summary>
	/// Enables event updates for the service.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartObservingCommandParams: ICommandParams<StartObservingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.BackgroundService.StartObserving;
		/// <summary>
		/// Service
		/// </summary>
		public string Service { get; set; }
	}
}
