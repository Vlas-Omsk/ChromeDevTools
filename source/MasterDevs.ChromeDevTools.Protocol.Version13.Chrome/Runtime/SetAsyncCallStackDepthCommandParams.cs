using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Enables or disables async call stacks tracking.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAsyncCallStackDepthCommandParams: ICommandParams<SetAsyncCallStackDepthCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.SetAsyncCallStackDepth;
		/// <summary>
		/// Maximum depth of async call stacks. Setting to `0` will effectively disable collecting async
		/// call stacks (default).
		/// </summary>
		public long MaxDepth { get; set; }
	}
}
