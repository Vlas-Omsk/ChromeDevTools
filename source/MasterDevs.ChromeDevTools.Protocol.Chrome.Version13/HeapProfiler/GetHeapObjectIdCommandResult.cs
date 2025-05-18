using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeapProfiler
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
