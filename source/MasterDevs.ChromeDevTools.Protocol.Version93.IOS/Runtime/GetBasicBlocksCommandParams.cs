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
	public class GetBasicBlocksCommandParams: ICommandParams<GetBasicBlocksCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.GetBasicBlocks;
		/// <summary>
		/// Indicates which sourceID information is requested for.
		/// </summary>
		public string SourceID { get; set; }
	}
}
