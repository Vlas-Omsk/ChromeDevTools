using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Highlights DOM node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class HighlightNodeCommand: ICommand<HighlightNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.HighlightNode;
	}
}
