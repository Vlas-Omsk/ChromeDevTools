using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
{
	/// <summary>
	/// Enables console to refer to the node with given id via $x (see Command Line API for more details
	/// $x functions).
	/// </summary>

	[SupportedBy("Chrome")]
	public class AddInspectedHeapObjectCommandParams: ICommandParams<AddInspectedHeapObjectCommandResult>
	{
		public string MethodName { get; } = ProtocolName.HeapProfiler.AddInspectedHeapObject;
		/// <summary>
		/// Heap snapshot object id to be accessible by means of $x command line API.
		/// </summary>
		public string HeapObjectId { get; set; }
	}
}
