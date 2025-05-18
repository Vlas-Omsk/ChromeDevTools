using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Profiler
{
	/// <summary>
	/// Collect coverage data for the current isolate. The coverage data may be incomplete due to
	/// garbage collection.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetBestEffortCoverageCommand: ICommand<GetBestEffortCoverageCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Profiler.GetBestEffortCoverage;
	}
}
