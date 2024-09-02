using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Profiler
{

	[SupportedBy("Chrome")]
	public class StopCommandParams: ICommandParams<StopCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Profiler.Stop;
	}
}
