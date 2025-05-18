using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.SystemInfo
{
	/// <summary>
	/// Returns information about the system.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetInfoCommand: ICommand<GetInfoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.SystemInfo.GetInfo;
	}
}
