using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Browser window bounds information
	/// </summary>
	[SupportedBy("Chrome")]
	public class Bounds
	{
		/// <summary>
		/// The offset from the left edge of the screen to the window in pixels.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Left { get; set; }
		/// <summary>
		/// The offset from the top edge of the screen to the window in pixels.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Top { get; set; }
		/// <summary>
		/// The window width in pixels.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Width { get; set; }
		/// <summary>
		/// The window height in pixels.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Height { get; set; }
		/// <summary>
		/// The window state. Default to normal.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public WindowState WindowState { get; set; }
	}
}
