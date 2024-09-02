using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Issued when new execution context is created.
	/// </summary>
	[EventName(ProtocolName.Runtime.ExecutionContextCreated)]
	[SupportedBy("Chrome")]
	public class ExecutionContextCreatedEventParams : IEventParams
	{
		/// <summary>
		/// A newly created execution context.
		/// </summary>
		public ExecutionContextDescription Context { get; set; }
	}
}
