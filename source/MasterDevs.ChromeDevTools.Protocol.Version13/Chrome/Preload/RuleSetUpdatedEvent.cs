using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	/// Upsert. Currently, it is only emitted when a rule set added.
	/// </summary>
	[Event(ProtocolName.Preload.RuleSetUpdated)]
	[SupportedBy("Chrome")]
	public class RuleSetUpdatedEvent
	{
		/// <summary>
		/// RuleSet
		/// </summary>
		public RuleSet RuleSet { get; set; }
	}
}
