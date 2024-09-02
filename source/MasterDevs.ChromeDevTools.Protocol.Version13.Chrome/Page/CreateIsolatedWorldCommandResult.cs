using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Creates an isolated world for the given frame.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CreateIsolatedWorldCommandResult : ICommandResult
	{
		/// <summary>
		/// Execution context of the isolated world.
		/// </summary>
		public long ExecutionContextId { get; set; }
	}
}
