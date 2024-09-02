using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Crashes renderer on the IO thread, generates minidumps.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CrashCommandResult : ICommandResult
	{
	}
}
