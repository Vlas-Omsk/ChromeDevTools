using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when EventSource message is received.
	/// </summary>
	[Event(ProtocolName.Network.EventSourceMessageReceived)]
	[SupportedBy("Chrome")]
	public class EventSourceMessageReceivedEvent
	{
		/// <summary>
		/// Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Message type.
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// Message identifier.
		/// </summary>
		public string EventId { get; set; }
		/// <summary>
		/// Message content.
		/// </summary>
		public string Data { get; set; }
	}
}
