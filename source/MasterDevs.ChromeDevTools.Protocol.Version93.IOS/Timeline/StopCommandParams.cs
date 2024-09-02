using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Timeline
{
	/// <summary>
	/// Stops capturing instrumentation events.
	/// </summary>

	[SupportedBy("IOS")]
	public class StopCommandParams: ICommandParams<StopCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Timeline.Stop;
	}
}
