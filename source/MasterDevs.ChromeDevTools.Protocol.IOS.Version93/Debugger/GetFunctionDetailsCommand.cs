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
	public class GetFunctionDetailsCommand: ICommand<GetFunctionDetailsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.GetFunctionDetails;
		/// <summary>
		/// Id of the function to get location for.
		/// </summary>
		public string FunctionId { get; set; }
	}
}
