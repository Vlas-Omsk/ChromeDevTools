using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// For testing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetHighlightObjectForTestCommandParams: ICommandParams<GetHighlightObjectForTestCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.GetHighlightObjectForTest;
		/// <summary>
		/// Id of the node to get highlight object for.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Whether to include distance info.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeDistance { get; set; }
		/// <summary>
		/// Whether to include style info.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeStyle { get; set; }
		/// <summary>
		/// The color format to get config with (default: hex).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ColorFormat { get; set; }
		/// <summary>
		/// Whether to show accessibility info (default: true).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowAccessibilityInfo { get; set; }
	}
}
