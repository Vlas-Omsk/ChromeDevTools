using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class GetObjectByHeapObjectIdCommandParams: ICommandParams<GetObjectByHeapObjectIdCommandResult>
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
