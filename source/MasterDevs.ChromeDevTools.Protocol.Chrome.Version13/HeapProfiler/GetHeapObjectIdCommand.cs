using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class GetHeapObjectIdCommand: ICommand<GetHeapObjectIdCommandResult>
	{
		public string MethodName { get; } = ProtocolName.HeapProfiler.GetHeapObjectId;
		/// <summary>
		/// Identifier of the object to get heap object id for.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
