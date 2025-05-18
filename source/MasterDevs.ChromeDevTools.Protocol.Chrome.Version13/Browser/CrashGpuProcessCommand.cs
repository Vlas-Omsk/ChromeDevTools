using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser
{
	/// <summary>
	/// Crashes GPU process.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CrashGpuProcessCommand: ICommand<CrashGpuProcessCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.CrashGpuProcess;
	}
}
