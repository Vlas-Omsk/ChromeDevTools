using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Console
{
	/// <summary>
	/// Issued when console is cleared. This happens either upon <code>clearMessages</code> command or after page navigation.
	/// </summary>
	[EventName(ProtocolName.Console.MessagesCleared)]
	[SupportedBy("IOS")]
	public class MessagesClearedEventParams : IEventParams
	{
	}
}
