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
	public class AddRuleCommandParams: ICommandParams<AddRuleCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.AddRule;
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Selector
		/// </summary>
		public string Selector { get; set; }
	}
}
