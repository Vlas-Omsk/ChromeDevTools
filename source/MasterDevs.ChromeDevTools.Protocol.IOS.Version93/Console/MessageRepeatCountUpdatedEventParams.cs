using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Console
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
