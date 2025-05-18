using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
{
	/// <summary>
	/// Attaches to the target with given id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class AttachToTargetCommand: ICommand<AttachToTargetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.AttachToTarget;
		/// <summary>
		/// TargetId
		/// </summary>
		public string TargetId { get; set; }
		/// <summary>
		/// Enables "flat" access to the session via specifying sessionId attribute in the commands.
		/// We plan to make this the default, deprecate non-flattened mode,
		/// and eventually retire it. See crbug.com/991325.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Flatten { get; set; }
	}
}
