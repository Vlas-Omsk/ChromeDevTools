using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Preload
{
	/// <summary>
	/// Upsert. Currently, it is only emitted when a rule set added.
	/// </summary>
	[EventName(ProtocolName.Preload.RuleSetUpdated)]
	[SupportedBy("Chrome")]
	public class RuleSetUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// RuleSet
		/// </summary>
		public RuleSet RuleSet { get; set; }
	}
}
