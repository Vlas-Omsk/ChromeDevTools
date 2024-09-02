using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Attaches to the browser target, only uses flat sessionId mode.
	/// </summary>

	[SupportedBy("Chrome")]
	public class AttachToBrowserTargetCommandResult : ICommandResult
	{
		/// <summary>
		/// Id assigned to the session.
		/// </summary>
		public string SessionId { get; set; }
	}
}
