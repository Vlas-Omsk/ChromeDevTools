using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime
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
