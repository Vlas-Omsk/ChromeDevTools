using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
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
