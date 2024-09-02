using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Inspector
{
	/// <summary>
	/// Fired when debugging target has crashed
	/// </summary>
	[EventName(ProtocolName.Inspector.TargetCrashed)]
	[SupportedBy("Chrome")]
	public class TargetCrashedEventParams : IEventParams
	{
	}
}
