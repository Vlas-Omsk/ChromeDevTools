using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when EventSource message is received.
	/// </summary>
	[EventName(ProtocolName.Network.EventSourceMessageReceived)]
	[SupportedBy("Chrome")]
	public class EventSourceMessageReceivedEventParams : IEventParams
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
