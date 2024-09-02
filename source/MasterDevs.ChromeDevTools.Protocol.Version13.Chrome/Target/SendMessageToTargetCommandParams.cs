using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Sends protocol message over session with given id.
	/// Consider using flat mode instead; see commands attachToTarget, setAutoAttach,
	/// and crbug.com/991325.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SendMessageToTargetCommandParams: ICommandParams<SendMessageToTargetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.SendMessageToTarget;
		/// <summary>
		/// Message
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Identifier of the session.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SessionId { get; set; }
		/// <summary>
		/// Deprecated.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
