using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
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
