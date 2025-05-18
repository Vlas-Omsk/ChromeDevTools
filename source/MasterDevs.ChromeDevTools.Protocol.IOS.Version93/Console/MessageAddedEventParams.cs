using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Console
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
