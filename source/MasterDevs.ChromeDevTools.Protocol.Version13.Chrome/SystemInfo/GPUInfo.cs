using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.SystemInfo
{
	/// <summary>
	/// Provides information about the GPU(s) on the system.
	/// </summary>
	[SupportedBy("Chrome")]
	public class GPUInfo
	{
		/// <summary>
		/// The graphics devices on the system. Element 0 is the primary GPU.
		/// </summary>
		public GPUDevice[] Devices { get; set; }
		/// <summary>
		/// An optional dictionary of additional GPU related attributes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object AuxAttributes { get; set; }
		/// <summary>
		/// An optional dictionary of graphics features and their status.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object FeatureStatus { get; set; }
		/// <summary>
		/// An optional array of GPU driver bug workarounds.
		/// </summary>
		public string[] DriverBugWorkarounds { get; set; }
		/// <summary>
		/// Supported accelerated video decoding capabilities.
		/// </summary>
		public VideoDecodeAcceleratorCapability[] VideoDecoding { get; set; }
		/// <summary>
		/// Supported accelerated video encoding capabilities.
		/// </summary>
		public VideoEncodeAcceleratorCapability[] VideoEncoding { get; set; }
		/// <summary>
		/// Supported accelerated image decoding capabilities.
		/// </summary>
		public ImageDecodeAcceleratorCapability[] ImageDecoding { get; set; }
	}
}
