using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by `nodeId`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetComputedStyleForNodeCommandParams: ICommandParams<GetComputedStyleForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetComputedStyleForNode;
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
