using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class GetObjectByHeapObjectIdCommandResult : ICommandResult
	{
		/// <summary>
		/// Evaluation result.
		/// </summary>
		public Runtime.RemoteObject Result { get; set; }
	}
}
