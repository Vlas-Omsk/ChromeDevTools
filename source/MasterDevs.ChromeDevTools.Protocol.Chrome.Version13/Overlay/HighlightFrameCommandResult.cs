using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Highlights owner element of the frame with given id.
	/// Deprecated: Doesn't work reliablity and cannot be fixed due to process
	/// separatation (the owner node might be in a different process). Determine
	/// the owner node in the client and use highlightNode.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class HighlightFrameCommandResult : ICommandResult
	{
	}
}
