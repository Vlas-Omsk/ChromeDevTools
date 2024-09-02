using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Ensures that the given node will have specified pseudo-classes whenever its style is computed by
	/// the browser.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ForcePseudoStateCommandResult : ICommandResult
	{
	}
}
