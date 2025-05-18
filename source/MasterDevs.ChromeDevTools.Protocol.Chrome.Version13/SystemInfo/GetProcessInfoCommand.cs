using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.SystemInfo
{
	/// <summary>
	/// Returns information about all running processes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetProcessInfoCommand: ICommand<GetProcessInfoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.SystemInfo.GetProcessInfo;
	}
}
