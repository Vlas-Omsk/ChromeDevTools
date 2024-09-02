using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Information about the request initiator.
	/// </summary>
	[SupportedBy("IOS")]
	public class Initiator
	{
		/// <summary>
		/// Type of this initiator.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Initiator JavaScript stack trace, set for Script only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Console.CallFrame[] StackTrace { get; set; }
		/// <summary>
		/// Initiator URL, set for Parser type only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Initiator line number, set for Parser type only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double LineNumber { get; set; }
	}
}
