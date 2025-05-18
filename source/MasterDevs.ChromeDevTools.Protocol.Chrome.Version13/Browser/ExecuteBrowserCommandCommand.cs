using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser
{
	/// <summary>
	/// Invoke custom browser commands used by telemetry.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ExecuteBrowserCommandCommand: ICommand<ExecuteBrowserCommandCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.ExecuteBrowserCommand;
		/// <summary>
		/// CommandId
		/// </summary>
		public string CommandId { get; set; }
	}
}
