using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Highlights the source order of the children of the DOM node with given id or with the given
	/// JavaScript object wrapper. Either nodeId or objectId must be specified.
	/// </summary>

	[SupportedBy("Chrome")]
	public class HighlightSourceOrderCommandResult : ICommandResult
	{
	}
}
