using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Issued when new execution context is created.
	/// </summary>
	[EventName(ProtocolName.Runtime.ExecutionContextCreated)]
	[SupportedBy("IOS")]
	public class ExecutionContextCreatedEventParams : IEventParams
	{
		/// <summary>
		/// A newly created execution contex.
		/// </summary>
		public ExecutionContextDescription Context { get; set; }
	}
}
