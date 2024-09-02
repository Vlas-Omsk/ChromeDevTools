using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Get position and size of the browser window.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetWindowBoundsCommandParams: ICommandParams<GetWindowBoundsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.GetWindowBounds;
		/// <summary>
		/// Browser window id.
		/// </summary>
		public long WindowId { get; set; }
	}
}
