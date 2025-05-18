using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Inspector
{
	/// <summary>
	/// Fired when remote debugging connection is about to be terminated. Contains detach reason.
	/// </summary>
	[EventName(ProtocolName.Inspector.Detached)]
	[SupportedBy("IOS")]
	public class DetachedEventParams : IEventParams
	{
		/// <summary>
		/// The reason why connection has been terminated.
		/// </summary>
		public string Reason { get; set; }
	}
}
