using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM attributes) for a DOM node identified by <code>nodeId</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetInlineStylesForNodeCommandParams: ICommandParams<GetInlineStylesForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetInlineStylesForNode;
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
