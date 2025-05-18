using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
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
