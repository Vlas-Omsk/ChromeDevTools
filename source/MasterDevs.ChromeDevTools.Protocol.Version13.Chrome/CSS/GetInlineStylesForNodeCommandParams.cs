using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM
	/// attributes) for a DOM node identified by `nodeId`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetInlineStylesForNodeCommandParams: ICommandParams<GetInlineStylesForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetInlineStylesForNode;
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
