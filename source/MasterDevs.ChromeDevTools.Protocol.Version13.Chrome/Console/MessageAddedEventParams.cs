using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Console
{
	/// <summary>
	/// Issued when new console message is added.
	/// </summary>
	[EventName(ProtocolName.Console.MessageAdded)]
	[SupportedBy("Chrome")]
	public class MessageAddedEventParams : IEventParams
	{
		/// <summary>
		/// Console message that has been added.
		/// </summary>
		public ConsoleMessage Message { get; set; }
	}
}
