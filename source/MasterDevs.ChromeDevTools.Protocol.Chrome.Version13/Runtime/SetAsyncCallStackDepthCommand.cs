using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{
	/// <summary>
	/// Enables or disables async call stacks tracking.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAsyncCallStackDepthCommand: ICommand<SetAsyncCallStackDepthCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.SetAsyncCallStackDepth;
		/// <summary>
		/// Maximum depth of async call stacks. Setting to `0` will effectively disable collecting async
		/// call stacks (default).
		/// </summary>
		public long MaxDepth { get; set; }
	}
}
