using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Request a global memory dump.
	/// </summary>
	[Command(ProtocolName.Tracing.RequestMemoryDump)]
	[SupportedBy("Chrome")]
	public class RequestMemoryDumpCommand: IProtocolCommand<RequestMemoryDumpCommandResponse>
	{
		/// <summary>
		/// Enables more deterministic results by forcing garbage collection
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Deterministic { get; set; }
		/// <summary>
		/// Specifies level of details in memory dump. Defaults to "detailed".
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string LevelOfDetail { get; set; }
	}
}
