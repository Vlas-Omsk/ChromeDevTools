using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Get the browser window that contains the devtools target.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetWindowForTargetCommandParams: ICommandParams<GetWindowForTargetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.GetWindowForTarget;
		/// <summary>
		/// Devtools agent host id. If called as a part of the session, associated targetId is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
