using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Inspector
{
	[EventName(ProtocolName.Inspector.Inspect)]
	[SupportedBy("IOS")]
	public class InspectEventParams : IEventParams
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
