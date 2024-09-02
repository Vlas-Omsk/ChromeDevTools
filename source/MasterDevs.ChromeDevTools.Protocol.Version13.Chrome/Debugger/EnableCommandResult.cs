using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Enables debugger for the given page. Clients should not assume that the debugging has been
	/// enabled until the result for this command is received.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EnableCommandResult : ICommandResult
	{
		/// <summary>
		/// Unique identifier of the debugger.
		/// </summary>
		public string DebuggerId { get; set; }
	}
}
