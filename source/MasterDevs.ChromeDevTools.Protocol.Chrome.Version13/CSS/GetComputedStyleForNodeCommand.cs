using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by `nodeId`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetComputedStyleForNodeCommand: ICommand<GetComputedStyleForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetComputedStyleForNode;
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
