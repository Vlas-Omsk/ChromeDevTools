using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetRuleSelectorCommandParams: ICommandParams<SetRuleSelectorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.SetRuleSelector;
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
