using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
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
