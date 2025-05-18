using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Fired when the page with currently enabled screencast was shown or hidden `.
	/// </summary>
	[EventName(ProtocolName.Page.ScreencastVisibilityChanged)]
	[SupportedBy("Chrome")]
	public class ScreencastVisibilityChangedEventParams : IEventParams
	{
		/// <summary>
		/// True if the page is visible.
		/// </summary>
		public bool Visible { get; set; }
	}
}
