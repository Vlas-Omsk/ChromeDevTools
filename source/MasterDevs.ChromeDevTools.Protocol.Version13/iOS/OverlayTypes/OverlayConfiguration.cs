using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	/// <summary>
	/// Data required to configure the overlay's size and scaling behavior.
	/// </summary>
	[SupportedBy("iOS")]
	public class OverlayConfiguration
	{
		/// <summary>
		/// DeviceScaleFactor
		/// </summary>
		public double DeviceScaleFactor { get; set; }
		/// <summary>
		/// ViewportSize
		/// </summary>
		public Size ViewportSize { get; set; }
		/// <summary>
		/// FrameViewFullSize
		/// </summary>
		public Size FrameViewFullSize { get; set; }
	}
}
