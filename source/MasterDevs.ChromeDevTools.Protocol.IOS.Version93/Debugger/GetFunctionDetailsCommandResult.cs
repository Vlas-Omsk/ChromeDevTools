using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
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
