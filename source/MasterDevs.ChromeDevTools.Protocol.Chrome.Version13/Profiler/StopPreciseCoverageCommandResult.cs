using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Profiler
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
