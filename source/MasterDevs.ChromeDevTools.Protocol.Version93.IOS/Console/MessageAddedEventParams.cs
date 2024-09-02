using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Console
{
	/// <summary>
	/// Issued when new console message is added.
	/// </summary>
	[EventName(ProtocolName.Console.MessageAdded)]
	[SupportedBy("IOS")]
	public class MessageAddedEventParams : IEventParams
	{
		/// <summary>
		/// Console message that has been added.
		/// </summary>
		public ConsoleMessage Message { get; set; }
	}
}
