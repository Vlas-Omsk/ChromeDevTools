using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Fired when the virtual machine resumed execution.
	/// </summary>
	[EventName(ProtocolName.Debugger.Resumed)]
	[SupportedBy("IOS")]
	public class ResumedEventParams : IEventParams
	{
	}
}
