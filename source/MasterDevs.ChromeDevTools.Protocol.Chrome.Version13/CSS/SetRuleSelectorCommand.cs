using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetRuleSelectorCommand: ICommand<SetRuleSelectorCommandResult>
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
