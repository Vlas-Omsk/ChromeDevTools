using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Returns attributes for the specified node.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetAttributesCommandParams: ICommandParams<GetAttributesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetAttributes;
		/// <summary>
		/// Id of the node to retrieve attibutes for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
