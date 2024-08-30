using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.GetHeapObjectId)]
	[SupportedBy("Chrome")]
	public class GetHeapObjectIdCommand: ICommandParams<GetHeapObjectIdCommandResponse>
	{
		/// <summary>
		/// Identifier of the object to get heap object id for.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
