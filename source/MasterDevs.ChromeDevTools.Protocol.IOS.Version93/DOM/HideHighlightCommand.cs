using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Hides DOM node highlight.
	/// </summary>

	[SupportedBy("IOS")]
	public class HideHighlightCommand: ICommand<HideHighlightCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.HideHighlight;
	}
}
