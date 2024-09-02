using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Profiler
{
	/// <summary>
	/// Collect coverage data for the current isolate. The coverage data may be incomplete due to
	/// garbage collection.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetBestEffortCoverageCommandResult : ICommandResult
	{
		/// <summary>
		/// Coverage data for the current isolate.
		/// </summary>
		public ScriptCoverage[] Result { get; set; }
	}
}
