using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>
	[Command(ProtocolName.CSS.SetRuleSelector)]
	[SupportedBy("iOS")]
	public class SetRuleSelectorCommand: ICommandParams<SetRuleSelectorCommandResponse>
	{
		/// <summary>
		/// RuleId
		/// </summary>
		public CSSRuleId RuleId { get; set; }
		/// <summary>
		/// Selector
		/// </summary>
		public string Selector { get; set; }
	}
}
