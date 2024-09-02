using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Crashes browser on the main thread.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CrashCommandParams: ICommandParams<CrashCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.Crash;
	}
}
