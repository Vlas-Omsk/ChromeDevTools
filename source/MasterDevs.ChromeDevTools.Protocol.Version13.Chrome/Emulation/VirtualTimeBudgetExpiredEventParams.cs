using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Notification sent after the virtual time budget for the current VirtualTimePolicy has run out.
	/// </summary>
	[EventName(ProtocolName.Emulation.VirtualTimeBudgetExpired)]
	[SupportedBy("Chrome")]
	public class VirtualTimeBudgetExpiredEventParams : IEventParams
	{
	}
}
