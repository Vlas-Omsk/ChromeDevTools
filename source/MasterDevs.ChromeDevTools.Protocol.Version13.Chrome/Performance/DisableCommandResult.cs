using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Performance
{
	/// <summary>
	/// Disable collecting and reporting metrics.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DisableCommandResult : ICommandResult
	{
	}
}
