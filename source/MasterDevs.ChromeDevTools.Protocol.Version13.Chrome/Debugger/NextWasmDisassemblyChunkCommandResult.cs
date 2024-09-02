using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Disassemble the next chunk of lines for the module corresponding to the
	/// stream. If disassembly is complete, this API will invalidate the streamId
	/// and return an empty chunk. Any subsequent calls for the now invalid stream
	/// will return errors.
	/// </summary>

	[SupportedBy("Chrome")]
	public class NextWasmDisassemblyChunkCommandResult : ICommandResult
	{
		/// <summary>
		/// The next chunk of disassembly.
		/// </summary>
		public WasmDisassemblyChunk Chunk { get; set; }
	}
}
