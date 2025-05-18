using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeapProfiler
{
	[EventName(ProtocolName.HeapProfiler.AddHeapSnapshotChunk)]
	[SupportedBy("Chrome")]
	public class AddHeapSnapshotChunkEventParams : IEventParams
	{
		/// <summary>
		/// Chunk
		/// </summary>
		public string Chunk { get; set; }
	}
}
