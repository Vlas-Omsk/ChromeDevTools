using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Issued when all executionContexts were cleared in browser
	/// </summary>
	[EventName(ProtocolName.Runtime.ExecutionContextsCleared)]
	[SupportedBy("Chrome")]
	public class ExecutionContextsClearedEventParams : IEventParams
	{
	}
}
