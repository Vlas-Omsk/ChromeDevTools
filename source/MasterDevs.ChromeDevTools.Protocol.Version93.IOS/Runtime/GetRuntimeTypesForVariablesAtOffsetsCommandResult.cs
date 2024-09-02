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
	public class GetRuntimeTypesForVariablesAtOffsetsCommandResult : ICommandResult
	{
		/// <summary>
		/// Types
		/// </summary>
		public TypeDescription[] Types { get; set; }
	}
}
