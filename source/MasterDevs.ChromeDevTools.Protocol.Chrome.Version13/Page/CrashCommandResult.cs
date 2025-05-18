using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Crashes renderer on the IO thread, generates minidumps.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CrashCommandResult : ICommandResult
	{
	}
}
