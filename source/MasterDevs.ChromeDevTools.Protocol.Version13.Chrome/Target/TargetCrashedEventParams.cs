using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Issued when a target has crashed.
	/// </summary>
	[EventName(ProtocolName.Target.TargetCrashed)]
	[SupportedBy("Chrome")]
	public class TargetCrashedEventParams : IEventParams
	{
		/// <summary>
		/// TargetId
		/// </summary>
		public string TargetId { get; set; }
		/// <summary>
		/// Termination status type.
		/// </summary>
		public string Status { get; set; }
		/// <summary>
		/// Termination error code.
		/// </summary>
		public long ErrorCode { get; set; }
	}
}
