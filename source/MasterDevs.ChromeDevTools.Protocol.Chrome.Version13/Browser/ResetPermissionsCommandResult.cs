using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser
{
	/// <summary>
	/// Reset all permission management for all origins.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResetPermissionsCommandResult : ICommandResult
	{
	}
}
