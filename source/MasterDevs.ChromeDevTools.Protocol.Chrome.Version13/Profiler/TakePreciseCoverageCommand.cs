using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Profiler
{
	/// <summary>
	/// Collect coverage data for the current isolate, and resets execution counters. Precise code
	/// coverage needs to have started.
	/// </summary>

	[SupportedBy("Chrome")]
	public class TakePreciseCoverageCommand: ICommand<TakePreciseCoverageCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Profiler.TakePreciseCoverage;
	}
}
