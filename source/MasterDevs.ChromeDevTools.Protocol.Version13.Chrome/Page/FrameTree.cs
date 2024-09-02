using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Information about the Frame hierarchy.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FrameTree
	{
		/// <summary>
		/// Frame information for this tree item.
		/// </summary>
		public Frame Frame { get; set; }
		/// <summary>
		/// Child frames.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FrameTree[] ChildFrames { get; set; }
	}
}
