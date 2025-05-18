using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// This command is deprecated. Use getScriptSource instead.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class GetWasmBytecodeCommand: ICommand<GetWasmBytecodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.GetWasmBytecode;
		/// <summary>
		/// Id of the Wasm script to get source for.
		/// </summary>
		public string ScriptId { get; set; }
	}
}
