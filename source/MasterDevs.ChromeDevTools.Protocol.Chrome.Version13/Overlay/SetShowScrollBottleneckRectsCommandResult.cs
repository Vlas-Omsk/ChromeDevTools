using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Requests that backend shows scroll bottleneck rects
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowScrollBottleneckRectsCommandResult : ICommandResult
	{
	}
}
