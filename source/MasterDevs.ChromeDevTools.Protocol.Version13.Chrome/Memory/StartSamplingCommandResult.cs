using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory
{
	/// <summary>
	/// Start collecting native memory profile.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartSamplingCommandResult : ICommandResult
	{
	}
}
