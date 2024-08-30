using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets node HTML markup, returns new node id.
	/// </summary>
	[Command(ProtocolName.DOM.SetOuterHTML)]
	[SupportedBy("Chrome")]
	public class SetOuterHTMLCommand: ICommandParams<SetOuterHTMLCommandResponse>
	{
		/// <summary>
		/// Id of the node to set markup for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Outer HTML markup to set.
		/// </summary>
		public string OuterHTML { get; set; }
	}
}
