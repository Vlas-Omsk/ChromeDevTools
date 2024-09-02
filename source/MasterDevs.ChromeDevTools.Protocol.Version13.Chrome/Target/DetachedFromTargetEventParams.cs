using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Issued when detached from target for any reason (including `detachFromTarget` command). Can be
	/// issued multiple times per target if multiple sessions have been attached to it.
	/// </summary>
	[EventName(ProtocolName.Target.DetachedFromTarget)]
	[SupportedBy("Chrome")]
	public class DetachedFromTargetEventParams : IEventParams
	{
		/// <summary>
		/// Detached session identifier.
		/// </summary>
		public string SessionId { get; set; }
		/// <summary>
		/// Deprecated.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
