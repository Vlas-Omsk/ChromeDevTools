using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{

	[SupportedBy("Chrome")]
	public class DisassembleWasmModuleCommandParams: ICommandParams<DisassembleWasmModuleCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.DisassembleWasmModule;
		/// <summary>
		/// Id of the script to disassemble
		/// </summary>
		public string ScriptId { get; set; }
	}
}
