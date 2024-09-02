using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Grant specific permissions to the given origin and reject all others.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GrantPermissionsCommandResult : ICommandResult
	{
	}
}
