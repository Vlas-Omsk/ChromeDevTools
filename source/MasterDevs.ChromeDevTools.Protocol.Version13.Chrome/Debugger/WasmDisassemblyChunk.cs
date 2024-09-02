using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	[SupportedBy("Chrome")]
	public class WasmDisassemblyChunk
	{
		/// <summary>
		/// The next chunk of disassembled lines.
		/// </summary>
		public string[] Lines { get; set; }
		/// <summary>
		/// The bytecode offsets describing the start of each line.
		/// </summary>
		public long[] BytecodeOffsets { get; set; }
	}
}
