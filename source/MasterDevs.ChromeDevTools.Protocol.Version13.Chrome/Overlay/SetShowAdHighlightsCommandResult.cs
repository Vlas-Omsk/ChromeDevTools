using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Highlights owner element of all frames detected to be ads.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowAdHighlightsCommandResult : ICommandResult
	{
	}
}
