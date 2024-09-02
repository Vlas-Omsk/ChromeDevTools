using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or
	/// objectId must be specified.
	/// </summary>

	[SupportedBy("Chrome")]
	public class HighlightNodeCommandResult : ICommandResult
	{
	}
}
