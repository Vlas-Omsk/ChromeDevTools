using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Information about the Frame hierarchy along with their cached resources.
	/// </summary>
	[SupportedBy("IOS")]
	public class FrameResourceTree
	{
		/// <summary>
		/// Frame information for this tree item.
		/// </summary>
		public Frame Frame { get; set; }
		/// <summary>
		/// Child frames.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FrameResourceTree[] ChildFrames { get; set; }
		/// <summary>
		/// Information about frame resources.
		/// </summary>
		public FrameResource[] Resources { get; set; }
	}
}
