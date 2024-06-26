using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Issued when exception was thrown and unhandled.
	/// </summary>
	[Event(ProtocolName.Runtime.ExceptionThrown)]
	[SupportedBy("Chrome")]
	public class ExceptionThrownEvent
	{
		/// <summary>
		/// Timestamp of the exception.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// ExceptionDetails
		/// </summary>
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
