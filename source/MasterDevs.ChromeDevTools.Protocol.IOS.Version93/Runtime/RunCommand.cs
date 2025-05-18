using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime
{
	/// <summary>
	/// Tells inspected instance(worker or page) that it can run in case it was started paused.
	/// </summary>

	[SupportedBy("IOS")]
	public class RunCommand: ICommand<RunCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.Run;
	}
}
