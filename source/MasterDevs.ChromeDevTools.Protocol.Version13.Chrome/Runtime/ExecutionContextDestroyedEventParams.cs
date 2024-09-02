using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Issued when execution context is destroyed.
	/// </summary>
	[EventName(ProtocolName.Runtime.ExecutionContextDestroyed)]
	[SupportedBy("Chrome")]
	public class ExecutionContextDestroyedEventParams : IEventParams
	{
		/// <summary>
		/// Id of the destroyed context
		/// </summary>
		public long ExecutionContextId { get; set; }
		/// <summary>
		/// Unique Id of the destroyed context
		/// </summary>
		public string ExecutionContextUniqueId { get; set; }
	}
}
