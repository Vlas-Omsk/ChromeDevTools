using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Called when global has been cleared and debugger client should reset its state. Happens upon navigation or reload.
	/// </summary>
	[EventName(ProtocolName.Debugger.GlobalObjectCleared)]
	[SupportedBy("IOS")]
	public class GlobalObjectClearedEventParams : IEventParams
	{
	}
}
