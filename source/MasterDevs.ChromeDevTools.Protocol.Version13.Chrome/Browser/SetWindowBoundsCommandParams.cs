using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Set position and/or size of the browser window.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetWindowBoundsCommandParams: ICommandParams<SetWindowBoundsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.SetWindowBounds;
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
