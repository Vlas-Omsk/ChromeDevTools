using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
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
