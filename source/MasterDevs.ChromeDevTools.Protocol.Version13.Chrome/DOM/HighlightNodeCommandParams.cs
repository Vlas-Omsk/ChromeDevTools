using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Highlights DOM node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class HighlightNodeCommandParams: ICommandParams<HighlightNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.HighlightNode;
	}
}
