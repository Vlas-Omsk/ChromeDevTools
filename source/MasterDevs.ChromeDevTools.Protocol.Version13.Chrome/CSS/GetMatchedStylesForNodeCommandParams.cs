using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Returns requested styles for a DOM node identified by `nodeId`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetMatchedStylesForNodeCommandParams: ICommandParams<GetMatchedStylesForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetMatchedStylesForNode;
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
