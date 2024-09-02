using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Preload
{
	[EventName(ProtocolName.Preload.RuleSetRemoved)]
	[SupportedBy("Chrome")]
	public class RuleSetRemovedEventParams : IEventParams
	{
		/// <summary>
		/// Id
		/// </summary>
		public string Id { get; set; }
	}
}
