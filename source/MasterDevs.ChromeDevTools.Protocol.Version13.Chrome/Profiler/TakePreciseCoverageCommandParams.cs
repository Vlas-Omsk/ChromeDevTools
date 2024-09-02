using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Profiler
{
	/// <summary>
	/// Collect coverage data for the current isolate, and resets execution counters. Precise code
	/// coverage needs to have started.
	/// </summary>

	[SupportedBy("Chrome")]
	public class TakePreciseCoverageCommandParams: ICommandParams<TakePreciseCoverageCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Profiler.TakePreciseCoverage;
	}
}
