using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Closes the target. If the target is a page that gets closed too.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CloseTargetCommandResult : ICommandResult
	{
		/// <summary>
		/// Always set to true. If an error occurs, the response indicates protocol error.
		/// </summary>
		public bool Success { get; set; }
	}
}
