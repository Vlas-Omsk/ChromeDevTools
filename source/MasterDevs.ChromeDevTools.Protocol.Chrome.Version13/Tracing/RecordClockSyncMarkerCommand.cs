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
	public class RecordClockSyncMarkerCommand: ICommand<RecordClockSyncMarkerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Tracing.RecordClockSyncMarker;
		/// <summary>
		/// The ID of this clock sync marker
		/// </summary>
		public string SyncId { get; set; }
	}
}
