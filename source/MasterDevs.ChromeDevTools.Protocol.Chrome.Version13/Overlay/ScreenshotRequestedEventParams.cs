using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Fired when user asks to capture screenshot of some area on the page.
	/// </summary>
	[EventName(ProtocolName.Overlay.ScreenshotRequested)]
	[SupportedBy("Chrome")]
	public class ScreenshotRequestedEventParams : IEventParams
	{
		/// <summary>
		/// Viewport to capture, in device independent pixels (dip).
		/// </summary>
		public Page.Viewport Viewport { get; set; }
	}
}
