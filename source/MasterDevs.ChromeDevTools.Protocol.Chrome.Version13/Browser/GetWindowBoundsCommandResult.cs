using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser
{
	/// <summary>
	/// Get position and size of the browser window.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetWindowBoundsCommandResult : ICommandResult
	{
		/// <summary>
		/// Bounds information of the window. When window state is 'minimized', the restored window
		/// position and size are returned.
		/// </summary>
		public Bounds Bounds { get; set; }
	}
}
