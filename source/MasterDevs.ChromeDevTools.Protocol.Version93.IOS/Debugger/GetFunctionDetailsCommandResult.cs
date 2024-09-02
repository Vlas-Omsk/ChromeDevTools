using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Returns detailed information on given function.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetFunctionDetailsCommandResult : ICommandResult
	{
		/// <summary>
		/// Information about the function.
		/// </summary>
		public FunctionDetails Details { get; set; }
	}
}
