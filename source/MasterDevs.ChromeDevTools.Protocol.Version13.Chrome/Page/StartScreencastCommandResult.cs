using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Starts sending each frame using the `screencastFrame` event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartScreencastCommandResult : ICommandResult
	{
	}
}
