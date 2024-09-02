using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Enables/disables rendering of local CSS fonts (enabled by default).
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetLocalFontsEnabledCommandResult : ICommandResult
	{
	}
}
