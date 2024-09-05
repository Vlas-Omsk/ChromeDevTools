using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns node id at given location. Depending on whether DOM domain is enabled, nodeId is
	/// either returned or not.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetNodeForLocationCommandParams: ICommandParams<GetNodeForLocationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetNodeForLocation;
		/// <summary>
		/// X coordinate.
		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Y coordinate.
		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// False to skip to the nearest non-UA shadow root ancestor (default: false).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeUserAgentShadowDOM { get; set; }
		/// <summary>
		/// Whether to ignore pointer-events: none on elements and hit test them.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IgnorePointerEventsNone { get; set; }
	}
}