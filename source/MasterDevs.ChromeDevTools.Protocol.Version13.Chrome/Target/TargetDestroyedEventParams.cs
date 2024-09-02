using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Issued when a target is destroyed.
	/// </summary>
	[EventName(ProtocolName.Target.TargetDestroyed)]
	[SupportedBy("Chrome")]
	public class TargetDestroyedEventParams : IEventParams
	{
		/// <summary>
		/// TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}
