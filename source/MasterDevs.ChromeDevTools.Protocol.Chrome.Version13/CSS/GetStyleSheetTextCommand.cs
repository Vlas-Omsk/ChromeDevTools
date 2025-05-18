using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Returns the current textual content for a stylesheet.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetStyleSheetTextCommand: ICommand<GetStyleSheetTextCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetStyleSheetText;
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
