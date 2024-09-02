using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Console
{
	/// <summary>
	/// Issued when subsequent message(s) are equal to the previous one(s).
	/// </summary>
	[EventName(ProtocolName.Console.MessageRepeatCountUpdated)]
	[SupportedBy("IOS")]
	public class MessageRepeatCountUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// New repeat count value.
		/// </summary>
		public long Count { get; set; }
	}
}
