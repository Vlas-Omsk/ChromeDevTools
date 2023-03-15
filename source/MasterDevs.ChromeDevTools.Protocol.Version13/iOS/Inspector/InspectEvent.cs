using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Inspector
{
	[Event(ProtocolName.Inspector.Inspect)]
	[SupportedBy("iOS")]
	public class InspectEvent
	{
		/// <summary>
		/// Object
		/// </summary>
		public Runtime.RemoteObject Object { get; set; }
		/// <summary>
		/// Hints
		/// </summary>
		public object Hints { get; set; }
	}
}
