using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Preload
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
