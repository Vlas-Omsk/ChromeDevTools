using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Tracing
{
	/// <summary>
	/// Record a clock sync marker in the trace.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RecordClockSyncMarkerCommandParams: ICommandParams<RecordClockSyncMarkerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Tracing.RecordClockSyncMarker;
		/// <summary>
		/// The ID of this clock sync marker
		/// </summary>
		public string SyncId { get; set; }
	}
}
