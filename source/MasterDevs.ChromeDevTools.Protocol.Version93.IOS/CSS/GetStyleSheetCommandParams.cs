using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Returns stylesheet data for the specified <code>styleSheetId</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetStyleSheetCommandParams: ICommandParams<GetStyleSheetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetStyleSheet;
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
