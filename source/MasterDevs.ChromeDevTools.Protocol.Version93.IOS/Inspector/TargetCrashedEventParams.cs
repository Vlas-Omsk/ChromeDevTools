using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Inspector
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
