using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory
{
	/// <summary>
	/// Stop collecting native memory profile.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopSamplingCommandResult : ICommandResult
	{
	}
}
