using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Request a global memory dump.
	/// </summary>
	[CommandResponse(ProtocolName.Tracing.RequestMemoryDump)]
	[SupportedBy("Chrome")]
	public class RequestMemoryDumpCommandResponse
	{
		/// <summary>
		/// GUID of the resulting global memory dump.
		/// </summary>
		public string DumpGuid { get; set; }
		/// <summary>
		/// True iff the global memory dump succeeded.
		/// </summary>
		public bool Success { get; set; }
	}
}
