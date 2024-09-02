using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Returns the current textual content for a stylesheet.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetStyleSheetTextCommandParams: ICommandParams<GetStyleSheetTextCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetStyleSheetText;
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
