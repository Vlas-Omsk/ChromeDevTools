using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Preload
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
