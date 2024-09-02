using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Inspector
{
	/// <summary>
	/// Fired when debugging target has reloaded after crash
	/// </summary>
	[EventName(ProtocolName.Inspector.TargetReloadedAfterCrash)]
	[SupportedBy("Chrome")]
	public class TargetReloadedAfterCrashEventParams : IEventParams
	{
	}
}
