using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Tracing
{
	/// <summary>
	/// Record a clock sync marker in the trace.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RecordClockSyncMarkerCommandResult : ICommandResult
	{
	}
}
