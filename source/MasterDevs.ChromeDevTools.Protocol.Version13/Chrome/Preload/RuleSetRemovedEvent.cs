using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	[Event(ProtocolName.Preload.RuleSetRemoved)]
	[SupportedBy("Chrome")]
	public class RuleSetRemovedEvent
	{
		/// <summary>
		/// Id
		/// </summary>
		public string Id { get; set; }
	}
}
