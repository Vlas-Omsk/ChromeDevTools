using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Timeline
{
	/// <summary>
	/// Stops capturing instrumentation events.
	/// </summary>

	[SupportedBy("IOS")]
	public class StopCommand: ICommand<StopCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Timeline.Stop;
	}
}
