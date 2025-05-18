using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Hides any highlight.
	/// </summary>

	[SupportedBy("Chrome")]
	public class HideHighlightCommand: ICommand<HideHighlightCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.HideHighlight;
	}
}
