using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by <code>nodeId</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetComputedStyleForNodeCommandParams: ICommandParams<GetComputedStyleForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetComputedStyleForNode;
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
