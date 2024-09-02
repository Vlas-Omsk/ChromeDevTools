using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Console
{
	/// <summary>
	/// Toggles monitoring of XMLHttpRequest. If <code>true</code>, console will receive messages upon each XHR issued.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetMonitoringXHREnabledCommandResult : ICommandResult
	{
	}
}
