using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Issued when some information about a target has changed. This only happens between
	/// `targetCreated` and `targetDestroyed`.
	/// </summary>
	[Event(ProtocolName.Target.TargetInfoChanged)]
	[SupportedBy("Chrome")]
	public class TargetInfoChangedEvent
	{
		/// <summary>
		/// TargetInfo
		/// </summary>
		public TargetInfo TargetInfo { get; set; }
	}
}
