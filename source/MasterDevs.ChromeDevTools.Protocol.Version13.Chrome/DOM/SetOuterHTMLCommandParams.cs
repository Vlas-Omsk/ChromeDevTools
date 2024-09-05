using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Sets node HTML markup, returns new node id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetOuterHTMLCommandParams: ICommandParams<SetOuterHTMLCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.SetOuterHTML;
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