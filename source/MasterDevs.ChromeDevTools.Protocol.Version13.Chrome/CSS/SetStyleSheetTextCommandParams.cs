using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Sets the new stylesheet text.
	/// </summary>

	[SupportedBy("Chrome")]
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
