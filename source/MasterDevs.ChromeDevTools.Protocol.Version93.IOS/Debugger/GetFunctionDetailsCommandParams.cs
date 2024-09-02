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
	public class GetFunctionDetailsCommandParams: ICommandParams<GetFunctionDetailsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.GetFunctionDetails;
		/// <summary>
		/// Id of the function to get location for.
		/// </summary>
		public string FunctionId { get; set; }
	}
}
