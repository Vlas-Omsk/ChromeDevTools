using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.GetComputedStyleForNode)]
	[SupportedBy("iOS")]
	public class GetComputedStyleForNodeCommand: ICommandParams<GetComputedStyleForNodeCommandResponse>
	{
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
