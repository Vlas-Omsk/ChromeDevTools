using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class CollectGarbageCommand: ICommand<CollectGarbageCommandResult>
	{
		public string MethodName { get; } = ProtocolName.HeapProfiler.CollectGarbage;
	}
}
