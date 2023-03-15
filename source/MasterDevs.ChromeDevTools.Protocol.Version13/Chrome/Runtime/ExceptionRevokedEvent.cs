using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Issued when unhandled exception was revoked.
	/// </summary>
	[Event(ProtocolName.Runtime.ExceptionRevoked)]
	[SupportedBy("Chrome")]
	public class ExceptionRevokedEvent
	{
		/// <summary>
		/// Reason describing why exception was revoked.
		/// </summary>
		public string Reason { get; set; }
		/// <summary>
		/// The id of revoked exception, as reported in `exceptionThrown`.
		/// </summary>
		public long ExceptionId { get; set; }
	}
}
