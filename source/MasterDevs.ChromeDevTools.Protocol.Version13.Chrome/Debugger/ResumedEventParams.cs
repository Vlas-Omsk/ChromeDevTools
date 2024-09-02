using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Fired when the virtual machine resumed execution.
	/// </summary>
	[EventName(ProtocolName.Debugger.Resumed)]
	[SupportedBy("Chrome")]
	public class ResumedEventParams : IEventParams
	{
	}
}
