using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM
	/// attributes) for a DOM node identified by `nodeId`.
	/// </summary>
	[Command(ProtocolName.CSS.GetInlineStylesForNode)]
	[SupportedBy("Chrome")]
	public class GetInlineStylesForNodeCommand: IProtocolCommand<GetInlineStylesForNodeCommandResponse>
	{
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
