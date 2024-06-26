using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Fired when HTTP response is available.
	/// </summary>
	[Event(ProtocolName.Network.ResponseReceived)]
	[SupportedBy("iOS")]
	public class ResponseReceivedEvent
	{
		/// <summary>
		/// Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Frame identifier.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Loader identifier.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Resource type.
		/// </summary>
		public Page.ResourceType Type { get; set; }
		/// <summary>
		/// Response data.
		/// </summary>
		public Response Response { get; set; }
	}
}
