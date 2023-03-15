using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Get the browser window that contains the devtools target.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.GetWindowForTarget)]
	[SupportedBy("Chrome")]
	public class GetWindowForTargetCommandResponse
	{
		/// <summary>
		/// Browser window id.
		/// </summary>
		public long WindowId { get; set; }
		/// <summary>
		/// Bounds information of the window. When window state is 'minimized', the restored window
		/// position and size are returned.
		/// </summary>
		public Bounds Bounds { get; set; }
	}
}
