using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Indicates whether a frame has been identified as an ad and why.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AdFrameStatus
	{
		/// <summary>
		/// AdFrameType
		/// </summary>
		public AdFrameType AdFrameType { get; set; }
		/// <summary>
		/// Explanations
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AdFrameExplanation[] Explanations { get; set; }
	}
}
