using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Inspector
{
	/// <summary>
	/// Fired when debugging target has crashed
	/// </summary>
	[EventName(ProtocolName.Inspector.TargetCrashed)]
	[SupportedBy("IOS")]
	public class TargetCrashedEventParams : IEventParams
	{
	}
}
