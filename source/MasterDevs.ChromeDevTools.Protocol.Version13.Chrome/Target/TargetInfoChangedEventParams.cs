using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Issued when some information about a target has changed. This only happens between
	/// `targetCreated` and `targetDestroyed`.
	/// </summary>
	[EventName(ProtocolName.Target.TargetInfoChanged)]
	[SupportedBy("Chrome")]
	public class TargetInfoChangedEventParams : IEventParams
	{
		/// <summary>
		/// TargetInfo
		/// </summary>
		public TargetInfo TargetInfo { get; set; }
	}
}
