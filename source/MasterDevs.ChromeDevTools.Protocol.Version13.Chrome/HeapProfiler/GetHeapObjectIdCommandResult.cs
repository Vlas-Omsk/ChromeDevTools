using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class GetHeapObjectIdCommandResult : ICommandResult
	{
		/// <summary>
		/// Id of the heap snapshot object corresponding to the passed remote object id.
		/// </summary>
		public string HeapSnapshotObjectId { get; set; }
	}
}
