using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Inserts a new rule with the given `ruleText` in a stylesheet with given `styleSheetId`, at the
	/// position specified by `location`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class AddRuleCommandResult : ICommandResult
	{
		/// <summary>
		/// The newly created rule.
		/// </summary>
		public CSSRule Rule { get; set; }
	}
}
