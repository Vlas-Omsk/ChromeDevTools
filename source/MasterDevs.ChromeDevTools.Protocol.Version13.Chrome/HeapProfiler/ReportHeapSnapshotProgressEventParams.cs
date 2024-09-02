using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
{
	[EventName(ProtocolName.HeapProfiler.ReportHeapSnapshotProgress)]
	[SupportedBy("Chrome")]
	public class ReportHeapSnapshotProgressEventParams : IEventParams
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
