using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class GetHeapObjectIdCommandParams: ICommandParams<GetHeapObjectIdCommandResult>
	{
		public string MethodName { get; } = ProtocolName.HeapProfiler.GetHeapObjectId;
		/// <summary>
		/// Identifier of the object to get heap object id for.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
