using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Notifies about a new protocol message received from the session (as reported in
	/// `attachedToTarget` event).
	/// </summary>
	[EventName(ProtocolName.Target.ReceivedMessageFromTarget)]
	[SupportedBy("Chrome")]
	public class ReceivedMessageFromTargetEventParams : IEventParams
	{
		/// <summary>
		/// Identifier of a session which sends a message.
		/// </summary>
		public string SessionId { get; set; }
		/// <summary>
		/// Message
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Deprecated.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
