using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Invoke custom browser commands used by telemetry.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ExecuteBrowserCommandCommandParams: ICommandParams<ExecuteBrowserCommandCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.ExecuteBrowserCommand;
		/// <summary>
		/// CommandId
		/// </summary>
		public string CommandId { get; set; }
	}
}
