using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Profiler
{
	/// <summary>
	/// Disable precise code coverage. Disabling releases unnecessary execution count records and allows
	/// executing optimized code.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopPreciseCoverageCommandResult : ICommandResult
	{
	}
}
