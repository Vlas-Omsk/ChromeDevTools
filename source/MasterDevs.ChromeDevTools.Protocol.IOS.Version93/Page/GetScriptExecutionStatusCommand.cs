using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Determines if scripts can be executed in the page.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetScriptExecutionStatusCommand: ICommand<GetScriptExecutionStatusCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetScriptExecutionStatus;
	}
}
