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
	public class EnableCommandParams: ICommandParams<EnableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.Enable;
		/// <summary>
		/// The maximum size in bytes of collected scripts (not referenced by other heap objects)
		/// the debugger can hold. Puts no limit if parameter is omitted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double MaxScriptsCacheSize { get; set; }
	}
}
