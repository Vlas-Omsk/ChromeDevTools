using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeapProfiler
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
