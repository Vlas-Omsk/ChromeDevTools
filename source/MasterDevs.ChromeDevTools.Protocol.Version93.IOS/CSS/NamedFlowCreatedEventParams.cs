using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Fires when a Named Flow is created.
	/// </summary>
	[EventName(ProtocolName.CSS.NamedFlowCreated)]
	[SupportedBy("IOS")]
	public class NamedFlowCreatedEventParams : IEventParams
	{
		/// <summary>
		/// The new Named Flow.
		/// </summary>
		public NamedFlow NamedFlow { get; set; }
	}
}
