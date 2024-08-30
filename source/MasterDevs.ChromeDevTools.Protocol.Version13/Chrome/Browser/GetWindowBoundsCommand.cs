using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Get position and size of the browser window.
	/// </summary>
	[Command(ProtocolName.Browser.GetWindowBounds)]
	[SupportedBy("Chrome")]
	public class GetWindowBoundsCommand: ICommandParams<GetWindowBoundsCommandResponse>
	{
		/// <summary>
		/// Browser window id.
		/// </summary>
		public long WindowId { get; set; }
	}
}
