using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{

	[SupportedBy("Chrome")]
	public class DisassembleWasmModuleCommand: ICommand<DisassembleWasmModuleCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.DisassembleWasmModule;
		/// <summary>
		/// Id of the script to disassemble
		/// </summary>
		public string ScriptId { get; set; }
	}
}
