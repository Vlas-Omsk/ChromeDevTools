using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Screencast frame metadata.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ScreencastFrameMetadata
	{
		/// <summary>
		/// Top offset in DIP.
		/// </summary>
		public double OffsetTop { get; set; }
		/// <summary>
		/// Page scale factor.
		/// </summary>
		public double PageScaleFactor { get; set; }
		/// <summary>
		/// Device screen width in DIP.
		/// </summary>
		public double DeviceWidth { get; set; }
		/// <summary>
		/// Device screen height in DIP.
		/// </summary>
		public double DeviceHeight { get; set; }
		/// <summary>
		/// Position of horizontal scroll in CSS pixels.
		/// </summary>
		public double ScrollOffsetX { get; set; }
		/// <summary>
		/// Position of vertical scroll in CSS pixels.
		/// </summary>
		public double ScrollOffsetY { get; set; }
		/// <summary>
		/// Frame swap timestamp.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Timestamp { get; set; }
	}
}
