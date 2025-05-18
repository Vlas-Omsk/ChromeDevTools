using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
{
	/// <summary>
	/// Returns stylesheet data for the specified <code>styleSheetId</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetStyleSheetCommand: ICommand<GetStyleSheetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetStyleSheet;
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
