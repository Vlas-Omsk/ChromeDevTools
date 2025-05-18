using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{
	/// <summary>
	/// Issued when exception was thrown and unhandled.
	/// </summary>
	[EventName(ProtocolName.Runtime.ExceptionThrown)]
	[SupportedBy("Chrome")]
	public class ExceptionThrownEventParams : IEventParams
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
