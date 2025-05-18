using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Inspector
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
