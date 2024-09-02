using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Disables reporting of execution contexts creation.
	/// </summary>

	[SupportedBy("IOS")]
	public class DisableCommandParams: ICommandParams<DisableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.Disable;
	}
}
