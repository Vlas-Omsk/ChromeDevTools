using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Returns detailed informtation on given function.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetRuntimeTypesForVariablesAtOffsetsCommandParams: ICommandParams<GetRuntimeTypesForVariablesAtOffsetsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.GetRuntimeTypesForVariablesAtOffsets;
		/// <summary>
		/// An array of type locations we're requesting information for. Results are expected in the same order they're sent in.
		/// </summary>
		public TypeLocation[] Locations { get; set; }
	}
}
