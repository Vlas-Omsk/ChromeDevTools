using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// This command is deprecated. Use getScriptSource instead.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class GetWasmBytecodeCommandResult : ICommandResult
	{
		/// <summary>
		/// Script source. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string Bytecode { get; set; }
	}
}
