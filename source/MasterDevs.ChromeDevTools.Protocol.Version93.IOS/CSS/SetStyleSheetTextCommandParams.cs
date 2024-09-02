using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Sets the new stylesheet text, thereby invalidating all existing <code>CSSStyleId</code>'s and <code>CSSRuleId</code>'s contained by this stylesheet.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetStyleSheetTextCommandParams: ICommandParams<SetStyleSheetTextCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.SetStyleSheetText;
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Text
		/// </summary>
		public string Text { get; set; }
	}
}
