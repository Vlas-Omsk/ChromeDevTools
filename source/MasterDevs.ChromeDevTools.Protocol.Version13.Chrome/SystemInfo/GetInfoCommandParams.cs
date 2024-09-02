using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about the system.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetInfoCommandParams: ICommandParams<GetInfoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.SystemInfo.GetInfo;
	}
}
