using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime
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
