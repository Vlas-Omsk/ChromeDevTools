using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Returns the JavaScript heap usage.
	/// It is the total usage of the corresponding isolate not scoped to a particular Runtime.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetHeapUsageCommandParams: ICommandParams<GetHeapUsageCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.GetHeapUsage;
	}
}
