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
	public class GetWindowBoundsCommand: ICommand<GetWindowBoundsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.GetWindowBounds;
		/// <summary>
		/// Browser window id.
		/// </summary>
		public long WindowId { get; set; }
	}
}
