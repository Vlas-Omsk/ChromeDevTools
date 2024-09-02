using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetOuterHTMLCommandParams: ICommandParams<GetOuterHTMLCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetOuterHTML;
		/// <summary>
		/// Id of the node to get markup for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
