using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Memory
{
	/// <summary>
	/// Simulate OomIntervention by purging V8 memory.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ForciblyPurgeJavaScriptMemoryCommandResult : ICommandResult
	{
	}
}
