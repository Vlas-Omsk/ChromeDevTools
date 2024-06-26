using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Invoke custom browser commands used by telemetry.
	/// </summary>
	[Command(ProtocolName.Browser.ExecuteBrowserCommand)]
	[SupportedBy("Chrome")]
	public class ExecuteBrowserCommandCommand: IProtocolCommand<ExecuteBrowserCommandCommandResponse>
	{
		/// <summary>
		/// CommandId
		/// </summary>
		public string CommandId { get; set; }
	}
}
