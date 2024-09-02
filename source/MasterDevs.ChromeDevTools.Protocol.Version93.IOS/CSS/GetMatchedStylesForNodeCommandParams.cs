using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Returns requested styles for a DOM node identified by <code>nodeId</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetMatchedStylesForNodeCommandParams: ICommandParams<GetMatchedStylesForNodeCommandResult>
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
