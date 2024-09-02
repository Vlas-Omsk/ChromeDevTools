using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Log
{
	/// <summary>
	/// Issued when new message was logged.
	/// </summary>
	[EventName(ProtocolName.Log.EntryAdded)]
	[SupportedBy("Chrome")]
	public class EntryAddedEventParams : IEventParams
	{
		/// <summary>
		/// The entry.
		/// </summary>
		public LogEntry Entry { get; set; }
	}
}
