using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Determines if scripts can be executed in the page.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetScriptExecutionStatusCommandParams: ICommandParams<GetScriptExecutionStatusCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetScriptExecutionStatus;
	}
}
