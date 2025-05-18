using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
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
