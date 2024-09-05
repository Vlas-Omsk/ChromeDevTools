using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Hides any highlight.
	/// </summary>

	[SupportedBy("Chrome")]
	public class HideHighlightCommandParams: ICommandParams<HideHighlightCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.HideHighlight;
	}
}