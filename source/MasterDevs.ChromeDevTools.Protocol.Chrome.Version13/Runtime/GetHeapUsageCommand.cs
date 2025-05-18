using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{
	/// <summary>
	/// Returns the JavaScript heap usage.
	/// It is the total usage of the corresponding isolate not scoped to a particular Runtime.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetHeapUsageCommand: ICommand<GetHeapUsageCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.GetHeapUsage;
	}
}
