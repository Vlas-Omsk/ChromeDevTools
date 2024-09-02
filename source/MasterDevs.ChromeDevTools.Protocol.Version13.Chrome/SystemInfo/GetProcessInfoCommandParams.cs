using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about all running processes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetProcessInfoCommandParams: ICommandParams<GetProcessInfoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.SystemInfo.GetProcessInfo;
	}
}
