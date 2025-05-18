using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
{
	/// <summary>
	/// Returns the current textual content and the URL for a stylesheet.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetStyleSheetTextCommand: ICommand<GetStyleSheetTextCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetStyleSheetText;
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
