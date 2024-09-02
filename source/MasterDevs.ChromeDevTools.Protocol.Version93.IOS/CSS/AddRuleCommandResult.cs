using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Creates a new empty rule with the given <code>selector</code> in a stylesheet with given <code>styleSheetId</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class AddRuleCommandResult : ICommandResult
	{
		/// <summary>
		/// The newly created rule.
		/// </summary>
		public CSSRule Rule { get; set; }
	}
}
