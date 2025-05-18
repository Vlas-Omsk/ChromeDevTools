using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class GetObjectByHeapObjectIdCommand: ICommand<GetObjectByHeapObjectIdCommandResult>
	{
		public string MethodName { get; } = ProtocolName.HeapProfiler.GetObjectByHeapObjectId;
		/// <summary>
		/// ObjectId
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Symbolic group name that can be used to release multiple objects.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
	}
}
