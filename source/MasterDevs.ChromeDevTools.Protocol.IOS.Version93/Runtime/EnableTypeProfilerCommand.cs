using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime
{
	/// <summary>
	/// Enables type profiling on the VM.
	/// </summary>

	[SupportedBy("IOS")]
	public class EnableTypeProfilerCommand: ICommand<EnableTypeProfilerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.EnableTypeProfiler;
	}
}
