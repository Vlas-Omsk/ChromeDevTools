using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Inspector
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
