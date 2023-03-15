using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Event(ProtocolName.HeapProfiler.ReportHeapSnapshotProgress)]
	[SupportedBy("Chrome")]
	public class ReportHeapSnapshotProgressEvent
	{
		/// <summary>
		/// Done
		/// </summary>
		public long Done { get; set; }
		/// <summary>
		/// Total
		/// </summary>
		public long Total { get; set; }
		/// <summary>
		/// Finished
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Finished { get; set; }
	}
}
