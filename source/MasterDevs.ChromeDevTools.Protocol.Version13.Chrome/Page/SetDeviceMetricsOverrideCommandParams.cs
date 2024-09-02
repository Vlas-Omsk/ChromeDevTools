using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Overrides the values of device screen dimensions (window.screen.width, window.screen.height,
	/// window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media
	/// query results).
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SetDeviceMetricsOverrideCommandParams: ICommandParams<SetDeviceMetricsOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetDeviceMetricsOverride;
		/// <summary>
		/// Overriding width value in pixels (minimum 0, maximum 10000000). 0 disables the override.
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Overriding height value in pixels (minimum 0, maximum 10000000). 0 disables the override.
		/// </summary>
		public long Height { get; set; }
		/// <summary>
		/// Overriding device scale factor value. 0 disables the override.
		/// </summary>
		public double DeviceScaleFactor { get; set; }
		/// <summary>
		/// Whether to emulate mobile device. This includes viewport meta tag, overlay scrollbars, text
		/// autosizing and more.
		/// </summary>
		public bool Mobile { get; set; }
		/// <summary>
		/// Scale to apply to resulting view image.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Scale { get; set; }
		/// <summary>
		/// Overriding screen width value in pixels (minimum 0, maximum 10000000).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ScreenWidth { get; set; }
		/// <summary>
		/// Overriding screen height value in pixels (minimum 0, maximum 10000000).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ScreenHeight { get; set; }
		/// <summary>
		/// Overriding view X position on screen in pixels (minimum 0, maximum 10000000).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? PositionX { get; set; }
		/// <summary>
		/// Overriding view Y position on screen in pixels (minimum 0, maximum 10000000).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? PositionY { get; set; }
		/// <summary>
		/// Do not set visible view size, rely upon explicit setVisibleSize call.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DontSetVisibleSize { get; set; }
		/// <summary>
		/// Screen orientation override.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Emulation.ScreenOrientation ScreenOrientation { get; set; }
		/// <summary>
		/// The viewport dimensions and scale. If not set, the override is cleared.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Viewport Viewport { get; set; }
	}
}
