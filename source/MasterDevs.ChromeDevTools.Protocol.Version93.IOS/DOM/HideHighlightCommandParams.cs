using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Hides DOM node highlight.
	/// </summary>

	[SupportedBy("IOS")]
	public class HideHighlightCommandParams: ICommandParams<HideHighlightCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.HideHighlight;
	}
}
