using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	/// <summary>
	/// A single region in a flow thread.
	/// </summary>
	[SupportedBy("iOS")]
	public class Region
	{
		/// <summary>
		/// BorderQuad
		/// </summary>
		public Point[] BorderQuad { get; set; }
		/// <summary>
		/// IncomingQuad
		/// </summary>
		public Point[] IncomingQuad { get; set; }
		/// <summary>
		/// OutgoingQuad
		/// </summary>
		public Point[] OutgoingQuad { get; set; }
		/// <summary>
		/// IsHighlighted
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsHighlighted { get; set; }
	}
}
