using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Highlights given rectangle.
	/// </summary>

	[SupportedBy("Chrome")]
	public class HighlightRectCommandParams: ICommandParams<HighlightRectCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.HighlightRect;
	}
}
