using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Issued when console API was called.
	/// </summary>
	[EventName(ProtocolName.Runtime.ConsoleAPICalled)]
	[SupportedBy("Chrome")]
	public class ConsoleAPICalledEventParams : IEventParams
	{
		/// <summary>
		/// Type of the call.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Call arguments.
		/// </summary>
		public RemoteObject[] Args { get; set; }
		/// <summary>
		/// Identifier of the context where the call was made.
		/// </summary>
		public long ExecutionContextId { get; set; }
		/// <summary>
		/// Call timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Stack trace captured when the call was made. The async stack chain is automatically reported for
		/// the following call types: `assert`, `error`, `trace`, `warning`. For other types the async call
		/// chain can be retrieved using `Debugger.getStackTrace` and `stackTrace.parentId` field.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StackTrace StackTrace { get; set; }
		/// <summary>
		/// Console context descriptor for calls on non-default console context (not console.*):
		/// 'anonymous#unique-logger-id' for call on unnamed context, 'name#unique-logger-id' for call
		/// on named context.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Context { get; set; }
	}
}
