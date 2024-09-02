using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetRuleSelectorCommandParams: ICommandParams<SetRuleSelectorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.SetRuleSelector;
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Range
		/// </summary>
		public SourceRange Range { get; set; }
		/// <summary>
		/// Selector
		/// </summary>
		public string Selector { get; set; }
	}
}
