using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory
{
	/// <summary>
	/// Simulate OomIntervention by purging V8 memory.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ForciblyPurgeJavaScriptMemoryCommandResult : ICommandResult
	{
	}
}
