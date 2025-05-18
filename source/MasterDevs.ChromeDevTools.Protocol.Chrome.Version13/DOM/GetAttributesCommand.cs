using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Returns attributes for the specified node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetAttributesCommand: ICommand<GetAttributesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetAttributes;
		/// <summary>
		/// Id of the node to retrieve attibutes for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
