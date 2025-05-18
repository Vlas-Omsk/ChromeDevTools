using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeapProfiler
{
	/// <summary>
	/// Enables console to refer to the node with given id via $x (see Command Line API for more details
	/// $x functions).
	/// </summary>

	[SupportedBy("Chrome")]
	public class AddInspectedHeapObjectCommandResult : ICommandResult
	{
	}
}
