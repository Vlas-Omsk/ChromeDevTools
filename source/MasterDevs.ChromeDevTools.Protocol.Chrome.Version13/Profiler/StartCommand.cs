using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Profiler
{

	[SupportedBy("Chrome")]
	public class StartCommand: ICommand<StartCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Profiler.Start;
	}
}
