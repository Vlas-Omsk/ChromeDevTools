using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Set position and/or size of the browser window.
	/// </summary>
	[Command(ProtocolName.Browser.SetWindowBounds)]
	[SupportedBy("Chrome")]
	public class SetWindowBoundsCommand: IProtocolCommand<SetWindowBoundsCommandResponse>
	{
		/// <summary>
		/// Browser window id.
		/// </summary>
		public long WindowId { get; set; }
		/// <summary>
		/// New window bounds. The 'minimized', 'maximized' and 'fullscreen' states cannot be combined
		/// with 'left', 'top', 'width' or 'height'. Leaves unspecified fields unchanged.
		/// </summary>
		public Bounds Bounds { get; set; }
	}
}
