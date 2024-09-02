using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Crashes GPU process.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CrashGpuProcessCommandParams: ICommandParams<CrashGpuProcessCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.CrashGpuProcess;
	}
}
