using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Tells inspected instance(worker or page) that it can run in case it was started paused.
	/// </summary>

	[SupportedBy("IOS")]
	public class RunCommandParams: ICommandParams<RunCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.Run;
	}
}
