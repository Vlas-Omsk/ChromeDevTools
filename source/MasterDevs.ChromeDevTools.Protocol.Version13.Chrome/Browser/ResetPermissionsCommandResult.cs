using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Reset all permission management for all origins.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResetPermissionsCommandResult : ICommandResult
	{
	}
}
