using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
{
	/// <summary>
	/// Returns requested styles for a DOM node identified by <code>nodeId</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetMatchedStylesForNodeCommand: ICommand<GetMatchedStylesForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetMatchedStylesForNode;
		/// <summary>
		/// NodeId
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Whether to include pseudo styles (default: true).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludePseudo { get; set; }
		/// <summary>
		/// Whether to include inherited styles (default: true).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeInherited { get; set; }
	}
}
