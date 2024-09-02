using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Inserts a new rule with the given `ruleText` in a stylesheet with given `styleSheetId`, at the
	/// position specified by `location`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class AddRuleCommandParams: ICommandParams<AddRuleCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.AddRule;
		/// <summary>
		/// The css style sheet identifier where a new rule should be inserted.
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// The text of a new rule.
		/// </summary>
		public string RuleText { get; set; }
		/// <summary>
		/// Text position of a new rule in the target style sheet.
		/// </summary>
		public SourceRange Location { get; set; }
	}
}
