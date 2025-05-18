using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Memory
{
	/// <summary>
	/// Start collecting native memory profile.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartSamplingCommandResult : ICommandResult
	{
	}
}
