using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
{
	/// <summary>
	/// Detaches session with given id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DetachFromTargetCommand: ICommand<DetachFromTargetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.DetachFromTarget;
		/// <summary>
		/// Session to detach.
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
