using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Returns a dictionary of accessibility properties for the node.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetAccessibilityPropertiesForNodeCommand: ICommand<GetAccessibilityPropertiesForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetAccessibilityPropertiesForNode;
		/// <summary>
		/// Id of the node for which to get accessibility properties.
		/// </summary>
		public long NodeId { get; set; }
	}
}
