using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Notification is issued every time when binding is called.
	/// </summary>
	[EventName(ProtocolName.Runtime.BindingCalled)]
	[SupportedBy("Chrome")]
	public class BindingCalledEventParams : IEventParams
	{
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Payload
		/// </summary>
		public string Payload { get; set; }
		/// <summary>
		/// Identifier of the context where the call was made.
		/// </summary>
		public long ExecutionContextId { get; set; }
	}
}
