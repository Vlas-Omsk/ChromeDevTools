using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows the FPS counter
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowFPSCounterCommandResult : ICommandResult
	{
	}
}
