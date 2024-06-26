using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Inspector
{
	/// <summary>
	/// Fired when remote debugging connection is about to be terminated. Contains detach reason.
	/// </summary>
	[Event(ProtocolName.Inspector.Detached)]
	[SupportedBy("iOS")]
	public class DetachedEvent
	{
		/// <summary>
		/// The reason why connection has been terminated.
		/// </summary>
		public string Reason { get; set; }
	}
}
