using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Discards collected exceptions and console API calls.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DiscardConsoleEntriesCommandResult : ICommandResult
	{
	}
}
