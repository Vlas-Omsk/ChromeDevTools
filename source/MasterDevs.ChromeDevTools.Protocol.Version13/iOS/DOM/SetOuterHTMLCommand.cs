using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Sets node HTML markup, returns new node id.
	/// </summary>
	[Command(ProtocolName.DOM.SetOuterHTML)]
	[SupportedBy("iOS")]
	public class SetOuterHTMLCommand: IProtocolCommand<SetOuterHTMLCommandResponse>
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
