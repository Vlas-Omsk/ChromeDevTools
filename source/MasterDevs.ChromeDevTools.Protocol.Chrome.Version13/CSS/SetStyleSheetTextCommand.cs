using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Sets the new stylesheet text.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetStyleSheetTextCommand: ICommand<SetStyleSheetTextCommandResult>
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
