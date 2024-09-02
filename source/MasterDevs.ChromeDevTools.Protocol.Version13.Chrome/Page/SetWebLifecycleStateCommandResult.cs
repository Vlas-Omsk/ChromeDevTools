using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Tries to update the web lifecycle state of the page.
	/// It will transition the page to the given state according to:
	/// https://github.com/WICG/web-lifecycle/
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetWebLifecycleStateCommandResult : ICommandResult
	{
	}
}
