using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
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
