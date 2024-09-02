using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
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
