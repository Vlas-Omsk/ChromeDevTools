using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Sets node HTML markup, returns new node id.
	/// </summary>

	[SupportedBy("IOS")]
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
