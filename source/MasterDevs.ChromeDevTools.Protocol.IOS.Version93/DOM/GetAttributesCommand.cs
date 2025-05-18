using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Returns attributes for the specified node.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetAttributesCommand: ICommand<GetAttributesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetAttributes;
		/// <summary>
		/// Id of the node to retrieve attibutes for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
