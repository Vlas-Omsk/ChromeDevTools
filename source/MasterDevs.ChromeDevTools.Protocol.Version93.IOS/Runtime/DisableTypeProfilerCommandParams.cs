using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Disables type profiling on the VM.
	/// </summary>

	[SupportedBy("IOS")]
	public class DisableTypeProfilerCommandParams: ICommandParams<DisableTypeProfilerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.DisableTypeProfiler;
	}
}
