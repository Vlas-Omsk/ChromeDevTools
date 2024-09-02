using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Returns a list of basic blocks for the given sourceID with information about their text ranges and whether or not they have executed.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetBasicBlocksCommandResult : ICommandResult
	{
		/// <summary>
		/// BasicBlocks
		/// </summary>
		public BasicBlock[] BasicBlocks { get; set; }
	}
}
