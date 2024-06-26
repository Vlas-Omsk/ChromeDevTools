using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Closes the target. If the target is a page that gets closed too.
	/// </summary>
	[CommandResponse(ProtocolName.Target.CloseTarget)]
	[SupportedBy("Chrome")]
	public class CloseTargetCommandResponse
	{
		/// <summary>
		/// Always set to true. If an error occurs, the response indicates protocol error.
		/// </summary>
		public bool Success { get; set; }
	}
}
