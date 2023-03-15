using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Issued when attached to target because of auto-attach or `attachToTarget` command.
	/// </summary>
	[Event(ProtocolName.Target.AttachedToTarget)]
	[SupportedBy("Chrome")]
	public class AttachedToTargetEvent
	{
		/// <summary>
		/// Identifier assigned to the session used to send/receive messages.
		/// </summary>
		public string SessionId { get; set; }
		/// <summary>
		/// TargetInfo
		/// </summary>
		public TargetInfo TargetInfo { get; set; }
		/// <summary>
		/// WaitingForDebugger
		/// </summary>
		public bool WaitingForDebugger { get; set; }
	}
}
