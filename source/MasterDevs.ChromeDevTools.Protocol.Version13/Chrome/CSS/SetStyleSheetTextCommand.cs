using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Sets the new stylesheet text.
	/// </summary>
	[Command(ProtocolName.CSS.SetStyleSheetText)]
	[SupportedBy("Chrome")]
	public class SetStyleSheetTextCommand: ICommandParams<SetStyleSheetTextCommandResponse>
	{
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
