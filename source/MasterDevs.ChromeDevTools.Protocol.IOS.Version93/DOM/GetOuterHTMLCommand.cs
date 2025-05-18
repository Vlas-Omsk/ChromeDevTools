using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetOuterHTMLCommand: ICommand<GetOuterHTMLCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetOuterHTML;
		/// <summary>
		/// Id of the node to get markup for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
